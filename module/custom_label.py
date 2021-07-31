import sys, os
from PyQt5 import QtCore, QtGui, QtWidgets
from PyQt5.QtCore import pyqtSignal
from module.illusion_filter_module import card_filter

class custom_Image_Label2(QtWidgets.QLabel):
    dropped = pyqtSignal(str)
    def __init__(self,parent):
        super().__init__(parent)
        font = QtGui.QFont()
        font.setPointSize(20)
        self.setFont(font)
        self.setText('Replace image')
        self.setGeometry(QtCore.QRect(500, 20, 361, 361))
        self.setFixedSize(361,361)
        self.setAcceptDrops(True)
        self.setFrameShape(QtWidgets.QFrame.Box)
        self.setAlignment(QtCore.Qt.AlignCenter)
        self.setObjectName("replaceImage")
        self.setStyleSheet('''
            QLabel#replaceImage{
                background-color: #ffe0d9;
                border: 4px dashed #aaa;
            }
        ''')


    def dragEnterEvent(self, event):
        if event.mimeData().hasImage:
            event.accept()
        else:
            event.ignore()

    def dragMoveEvent(self, event):
        if event.mimeData().hasImage:
            event.accept()
        else:
            event.ignore()

    def dropEvent(self, event):
        if not event.mimeData().urls()[0].toLocalFile().endswith((".png",".jpg",".jpeg",".jiff")):
            QtWidgets.QMessageBox.warning(self, "Error", "only PNG, JPG, JPEG, JIFF")
        elif event.mimeData().urls()[0].toLocalFile().endswith((".png",".jpg",".jpeg",".jiff")):
            event.setDropAction(QtCore.Qt.CopyAction)
            self.set_image(event.mimeData().urls()[0].toLocalFile())
            self.dropped.emit(event.mimeData().urls()[0].toLocalFile())
            event.accept()
        else:
            event.ignore()

    def set_image(self, file_path):
        self.setPixmap(QtGui.QPixmap(file_path).scaled(self.width(), self.height(), QtCore.Qt.KeepAspectRatioByExpanding))

    def reset_data(self):
        self.setText('Replace image')

class custom_Image_Label(custom_Image_Label2):
    dropped = pyqtSignal(str)
    def __init__(self,parent):
        super().__init__(parent)
        font = QtGui.QFont()
        font.setPointSize(20)
        self.setFont(font)
        self.setText('Card')
        self.setGeometry(QtCore.QRect(50, 20, 361, 361))
        self.setFixedSize(361,361)
        self.setAcceptDrops(True)
        self.setFrameShape(QtWidgets.QFrame.Box)
        self.setAlignment(QtCore.Qt.AlignCenter)
        self.setObjectName("card")
        self.setStyleSheet('''
            QLabel#card{
                background-color: #d9ffff;
                border: 4px dashed #aaa;
            }
        ''')

    def dropEvent(self, event):
        if not event.mimeData().urls()[0].toLocalFile().endswith('.png'):
            QtWidgets.QMessageBox.warning(self, "Error", "only png")
        elif event.mimeData().urls()[0].toLocalFile().endswith('.png'):
            if card_filter(event.mimeData().urls()[0].toLocalFile()):
                event.setDropAction(QtCore.Qt.CopyAction)
                self.set_image(event.mimeData().urls()[0].toLocalFile())
                self.dropped.emit(event.mimeData().urls()[0].toLocalFile())
                event.accept()
            else:
                QtWidgets.QMessageBox.warning(self, "Error", "This file is not relate to Koikatsu, Ai-Shoujo or Honey Select 2")
                event.ignore()
        else:
            event.ignore()

    def set_image(self, file_path):
        self.setPixmap(QtGui.QPixmap(file_path).scaled(self.width(), self.height(), QtCore.Qt.KeepAspectRatio))

    def reset_data(self):
        self.setText('Card')