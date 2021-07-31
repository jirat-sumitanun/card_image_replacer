import os,datetime
from shutil import copy as shutilCopy
from PIL import Image
from module.illusion_filter_module import card_filter

# main
def create_new_card(original_card_path, replace_image_path, saved_new_card_path):
    checkReplacedImageFileExt(replace_image_path, saved_new_card_path)
    writeCharacterData(original_card_path, saved_new_card_path)
    #convertJPGtoPNG(replace_image_path,saved_new_card_path)
    #copyCardData2(original_card_path,replace_image_path,saved_new_card_path)


def checkReplacedImageFileExt(replace_image_path, saved_new_card_path):
    if replace_image_path.endswith(('.jpg', '.jpeg', '.jiff')):
        convertJPGtoPNG(replace_image_path, saved_new_card_path)
    elif replace_image_path.endswith('.png'):
        if(card_filter(replace_image_path)):
            extract_only_image(replace_image_path,saved_new_card_path)
        else:
            create_copied_empty_card(replace_image_path, saved_new_card_path)

def convertJPGtoPNG(replaced_image_path, saved_new_card_path):
    v1 = Image.open(replaced_image_path)
    v1.save(saved_new_card_path,"png")



def create_copied_empty_card(replaced_image_path, saved_new_card_path):
    shutilCopy(replaced_image_path, saved_new_card_path)
    #extract_only_image(replaced_image_path,saved_new_card_path)


def writeCharacterData(original_card_path, saved_new_card_path):
    with open (original_card_path, 'rb') as f:
        s = f.read()
        byte_to_search = b"IEND\xaeB`\x82"
        card_data = s.split(byte_to_search)
        with open (saved_new_card_path, 'ab') as newCard:
            for i in range(1,len(card_data)-1):
                newCard.write(card_data[i])
                newCard.write(byte_to_search)
            newCard.write(card_data[len(card_data)-1])

def extract_only_image(src,dest):
    byte_to_find = b"IEND\xaeB`\x82"
    if not (os.path.exists(os.path.join(os.getcwd(),'extract'))):
        os.mkdir(os.path.join(os.getcwd(),'extract'))
    x = datetime.datetime.now()
    filename = "extract_{}.png".format(x.strftime("%Y%m%d%H%M%S%f"))
    save_path = os.path.join(os.path.join(os.getcwd(),'extract'),filename)
    if not src.endswith(".png"):
        convertJPGtoPNG(src,save_path)
        return
    if dest == None:
        with open(src,'rb') as to_extract:
            s = to_extract.read()
            image_data_end_index =  s.split(byte_to_find)
            with open(save_path,'ab') as extract_image:
                for i in range(0,1):
                    extract_image.write(image_data_end_index[i])
                extract_image.write(byte_to_find)
    else:
        with open(src,'rb') as to_extract:
            s = to_extract.read()
            image_data_end_index =  s.split(byte_to_find)
            with open(dest,'ab') as extract_image:
                for i in range(0,1):
                    extract_image.write(image_data_end_index[i])
                extract_image.write(byte_to_find)

# def copyCardData2(card_path,replace_path,save_path):
#     arr = []
#     arr2 = []
#     text_to_find = b"IEND\xaeB`\x82"
#     try:
#         with open(save_path+"_temp.png",'rb') as replaceImage:
#             s = replaceImage.read()
#             v1 = s.find(text_to_find)
#             for i in range(0,v1+8):
#                 arr.append(s[i])
#         with open(card_path,'rb') as card:
#             s = card.read()
#             v1 = s.find(text_to_find)
#             for i in range(len(s)):
#                 arr2.append(s[i])
#             arr2 = arr2[v1+8:]
#         arr.extend(arr2)
#         with open(save_path,'wb') as newCard:
#             newCard.write(bytearray(arr))
#         os.remove(save_path+"_temp.png")
#     except Exception as e:
#         print(e)