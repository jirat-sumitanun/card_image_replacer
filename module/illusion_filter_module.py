def card_filter(file_path):
    with open(file_path,'rb') as readImage:
        imageData = readImage.read()
        if b'KStudio' in imageData:
            return True
        elif b"KoiKatuCharaSun" in imageData:
            return True
        elif b"KoiKatuChara" in imageData:
            return True
        elif b"KoiKatuClothes" in imageData:
            return True
        if b'StudioNEOV2' in imageData:
            return True
        elif b"AIS_Chara" in imageData:
            return True
        elif b"AIS_Clothes" in imageData:
            return True
        else:
            return False