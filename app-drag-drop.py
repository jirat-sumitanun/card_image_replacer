#! src/Scripts/python
import sys
from os import path as osPath ,getcwd as osGetcwd
from PyQt5 import QtCore, QtGui, QtWidgets
from PyQt5.QtCore import pyqtSignal, pyqtSlot
from module.utils import create_new_card, extract_only_image
from module.appUi import Ui_Form
#from module.main import Ui_Form
from module.custom_label import custom_Image_Label, custom_Image_Label2


class MyApp(QtWidgets.QMainWindow):
    def __init__(self, parent=None):
        QtWidgets.QWidget.__init__(self, parent)
        # init main window
        self.ui = Ui_Form()
        self.ui.setupUi(self)
        self.ui.icon = QtGui.QIcon()
        self.ui.icon.addPixmap(QtGui.QPixmap(image_path), QtGui.QIcon.Normal, QtGui.QIcon.Off)
        self.setWindowIcon(self.ui.icon)
        self.ui.card = custom_Image_Label(self)
        self.ui.replaceImage = custom_Image_Label2(self)
        self.ui.gridLayout.addWidget(self.ui.card,0,0)
        self.ui.gridLayout.addWidget(self.ui.replaceImage,0,1)
        # init default data
        self.saveFilename = ''
        self.savePath = ''
        # init button event
        self.ui.selectCard.clicked.connect(self.select_card_event)
        self.ui.selectReplaceImage.clicked.connect(self.select_replace_image_event)
        self.ui.saveBtn.clicked.connect(self.save_file)
        self.ui.saveAsBtn.clicked.connect(self.save_file_as)
        self.ui.clearBtn.clicked.connect(self.clear_button_event)
        self.ui.exportBtn.clicked.connect(self.extract_image_event)
        self.ui.card.dropped.connect(self.dropEventHandle)
        self.ui.filename.textEdited.connect(self.changeFilenameHandle)


    @pyqtSlot()
    def dropEventHandle(self):
        filename, ext = osPath.splitext(self.ui.card.path.split('/')[-1])
        self.ui.filename.setText('new_{}'.format(filename))
        self.saveFilename = 'new_{}'.format(filename)

    @pyqtSlot()
    def changeFilenameHandle(self):
        self.saveFilename = self.ui.filename.text()

    def select_card_event(self):
        selected_card,filters = QtWidgets.QFileDialog.getOpenFileName(None, 'Select card', filter="*png")
        if selected_card != "":
            self.ui.card.path = selected_card
            self.ui.saveLabel.setText("")
            filename, ext = osPath.splitext(self.ui.card.path.split('/')[-1])
            self.ui.filename.setText('new_{}'.format(filename))
            self.saveFilename = 'new_{}'.format(filename)
            self.ui.card.set_image(self.ui.card.path)
        # self.ui.card.path = selected_card
        # if self.ui.card.path != "":
        #     self.ui.saveLabel.setText("")
        #     filename, ext = osPath.splitext(self.ui.card.path.split('/')[-1])
        #     self.ui.filename.setText('new_{}'.format(filename))
        #     self.ui.card.set_image(self.ui.card.path)
        # else:
        #     self.ui.filename.setText("")
        #     self.ui.saveLabel.setText("")
        #     self.ui.card.path = ""

    def select_replace_image_event(self):
        self.ui.replaceImage.path,filters =  QtWidgets.QFileDialog.getOpenFileName(None, 'Select replace image', filter="Images (*png *jpg *jpeg *jiff)")
        if self.ui.replaceImage.path != "":
            self.ui.saveLabel.setText("")
            self.ui.replaceImage.set_image(self.ui.replaceImage.path)
        else:
            self.ui.saveLabel.setText("")

    def save_file(self):
        if self.errorHandler():
            self.saveFilename = self.ui.filename.text() + '.png'
            self.savePath = osPath.join(osGetcwd(), self.saveFilename)
            self.saveNewCard()
            self.save_success_message()

    def save_file_as(self):
        if self.errorHandler():
            filename, ext = osPath.splitext(self.ui.card.path.split('/')[-1])
            self.ui.filename.setText('new_{}'.format(filename))
            self.saveFilename = self.ui.filename.text() + '.png'
            save_file_path,filters = QtWidgets.QFileDialog.getSaveFileName(None, 'Save new card',osPath.join(osPath.dirname(self.ui.card.path), self.saveFilename), filter="*png")
            if save_file_path != "":
                self.savePath = save_file_path
                self.saveNewCard()
                self.save_success_message()

    def saveNewCard(self):
        try:
            create_new_card(self.ui.card.path,self.ui.replaceImage.path,self.savePath)
        except Exception as e:
            QtWidgets.QMessageBox.warning(self, "Error", "capture this and report to dev\n{}".format(e))

    def save_success_message(self):
        self.ui.saveLabel.setText("saved!")

    def clear_button_event(self):
        self.ui.saveLabel.setText("")
        self.ui.filename.setText("")
        self.ui.card.reset_data()
        self.ui.replaceImage.reset_data()

    def errorHandler(self):
        if self.ui.card.path == "":
            QtWidgets.QMessageBox.warning(self, "Error", "import card")
            return False
        if self.ui.replaceImage.path == "":
            QtWidgets.QMessageBox.warning(self, "Error", "import replace image")
            return False
        if self.ui.filename.text() == "":
            if self.ui.card.path == "":
                QtWidgets.QMessageBox.warning(self, "Error", "fill filename")
                return False
        return True


    def extract_image_event(self):
        extract_only_image(self.ui.card.path,None)

    # def check_card_type(self,selected_card):
    #     if selected_card == '':
    #         return False
    #     if self.mode_selected == 'chara':
    #         if not checkIsCharacterCard(selected_card):
    #             QtWidgets.QMessageBox.warning(self, "Error", "This is not Character Card")
    #         else:
    #             return True
    #     elif self.mode_selected == 'clothes':
    #         if not checkIsCoordinateCard(selected_card):
    #             QtWidgets.QMessageBox.warning(self, "Error", "This is not Coordinate Card")
    #         else:
    #             return True

def resource_path(relative_path):
        """ Get absolute path to resource, works for dev and for PyInstaller """
        base_path = getattr(sys, '_MEIPASS', osPath.dirname(osPath.abspath(__file__)))
        return osPath.join(base_path, relative_path)
image_path = resource_path("img/icon01.ico")


def main():
    try:
        app = QtWidgets.QApplication(sys.argv)
        myapp = MyApp()
        myapp.show()
        sys.exit(app.exec_())
    except Exception as e:
        print(e)
if __name__== "__main__" :
    main()