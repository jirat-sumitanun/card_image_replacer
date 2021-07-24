import os
from shutil import copy as shutilCopy
from PIL import Image

# main
def create_new_card(original_card_path, replace_image_path, saved_new_card_path):
    checkReplacedImageFileExt(replace_image_path, saved_new_card_path)
    writeCharacterData(original_card_path, saved_new_card_path)


def checkReplacedImageFileExt(replace_image_path, saved_new_card_path):
    if replace_image_path.endswith(('.jpg', '.jpeg', '.jiff')):
        convertJPGtoPNG(replace_image_path, saved_new_card_path)
    elif replace_image_path.endswith('.png'):
        create_copied_card(replace_image_path, saved_new_card_path)


def convertJPGtoPNG(replaced_image_path, saved_new_card_path):
    v1 = Image.open(replaced_image_path)
    v1.save(saved_new_card_path)


def create_copied_card(replaced_image_path, saved_new_card_path):
    #shutilCopy(replaced_image_path, saved_new_card_path)
    extract_only_image(replaced_image_path,saved_new_card_path)


def writeCharacterData(original_card_path, saved_new_card_path):
    with open (original_card_path, 'rb') as f:
        s = f.read()
        text = b"IEND\xaeB`\x82"
        card_data = s.split(text)
        with open (saved_new_card_path, 'ab') as newCard:
            for i in range(1,len(card_data)):
                newCard.write(card_data[i])
                newCard.write(text)


def extract_only_image(src,dest):
    path, ext = os.path.splitext(src)
    filename = path.replace('\\','/').split('/').pop()
    with open (src, 'rb') as f:
        s = f.read()
        text = b"IEND\xaeB`\x82"
        card_data = s.split(text)
        if dest == None:
            if not os.path.isdir(os.path.join(os.getcwd(),"extract_png")):
                os.mkdir(os.path.join(os.getcwd(),"extract_png"))
            with open ("extract_png/extract_%s%s"%(filename,ext), 'ab') as extractPng:
                for i in range(0,2):
                    extractPng.write(card_data[i])
                    extractPng.write(text)
        else:
            with open (dest, 'ab') as extractPng:
                for i in range(0,2):
                    extractPng.write(card_data[i])
                    extractPng.write(text)