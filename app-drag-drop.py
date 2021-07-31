#! src/Scripts/python
import sys, os
from PyQt5 import QtCore, QtGui, QtWidgets
from PyQt5.QtCore import pyqtSignal, pyqtSlot
from module.utils import create_new_card, extract_only_image
from module.appUi import Ui_Form
#from module.main import Ui_Form
from module.custom_label import custom_Image_Label, custom_Image_Label2
from module.illusion_filter_module import card_filter


class MyApp(QtWidgets.QMainWindow):
    def __init__(self, parent=None):
        QtWidgets.QWidget.__init__(self, parent)
        # init main window
        self.ui = Ui_Form()
        self.ui.setupUi(self)
        self.ui.icon = QtGui.QIcon()
        self.ui.icon.addPixmap(QtGui.QPixmap(image_path), QtGui.QIcon.Normal, QtGui.QIcon.Off)
        self.setWindowIcon(self.ui.icon)
        self.ui.card_box = custom_Image_Label(self)
        self.ui.replaceImage_box = custom_Image_Label2(self)
        self.ui.gridLayout.addWidget(self.ui.card_box,0,0)
        self.ui.gridLayout.addWidget(self.ui.replaceImage_box,0,1)
        # init default data
        self.card_path = ""
        self.savePath = ''
        self.replaceImage_path = ""
        #self.saveFilename = ""
        # init button event
        self.ui.selectCard.clicked.connect(self.select_card_event)
        self.ui.selectReplaceImage.clicked.connect(self.select_replace_image_event)
        self.ui.saveBtn.clicked.connect(self.save_file)
        self.ui.saveAsBtn.clicked.connect(self.save_file_as)
        self.ui.clearBtn.clicked.connect(self.clear_button_event)
        self.ui.exportBtn.clicked.connect(self.extract_image_event)
        # init Drop image event
        self.ui.card_box.dropped.connect(self.dropCardEvent)
        self.ui.replaceImage_box.dropped.connect(self.dropReplaceImageEvent)
        #self.ui.filename.textEdited.connect(self.changeFilenameHandle)


    @pyqtSlot(str)
    def dropCardEvent(self,card_path):
        self.card_path = card_path
        filename, ext = os.path.splitext(card_path.split('/').pop())
        self.ui.filename.setText('new_{}'.format(filename))

    @pyqtSlot(str)
    def dropReplaceImageEvent(self,replaceImage_path):
        self.replaceImage_path = replaceImage_path


    def select_card_event(self):
        self.ui.saveLabel.setText("")
        selected_card,filters = QtWidgets.QFileDialog.getOpenFileName(None, 'Select card', filter="*png")
        if selected_card != "":
            if card_filter(selected_card):
                self.ui.card_box.set_image(selected_card)
                self.card_path = selected_card
                filename, ext = os.path.splitext(os.path.basename(selected_card))
                self.ui.filename.setText('new_{}'.format(filename))
            else:
                QtWidgets.QMessageBox.warning(self, "Error", "This file is not relate to Koikatsu, Ai-Shoujo or Honey Select 2")

    def select_replace_image_event(self):
        self.ui.saveLabel.setText("")
        selected_replace_image, filters =  QtWidgets.QFileDialog.getOpenFileName(None, 'Select replace image', filter="Images (*png *jpg *jpeg *jiff)")
        if selected_replace_image != "":
            self.ui.replaceImage_box.set_image(selected_replace_image)
            self.replaceImage_path = selected_replace_image

    def save_file(self):
        if self.errorHandler():
            self.saveFilename = f"{self.ui.filename.text()}.png"
            save_dir = os.path.dirname(self.card_path)
            self.savePath = os.path.join(save_dir,self.saveFilename).replace('\\','/')
            self.saveNewCard()
            self.save_success_message()

    def save_file_as(self):
        if self.errorHandler():
            self.saveFilename = f"{self.ui.filename.text()}.png"
            save_dir = os.path.dirname(self.card_path)
            self.savePath = os.path.join(save_dir,self.saveFilename).replace('\\','/')
            save_file_path,filters = QtWidgets.QFileDialog.getSaveFileName(None, 'Save new card',self.savePath, filter="*png")
            if save_file_path != "":
                self.saveNewCard()
                self.save_success_message()

    def saveNewCard(self):
        try:
            create_new_card(self.card_path,self.replaceImage_path,self.savePath)
        except Exception as e:
            QtWidgets.QMessageBox.warning(self, "Error", "capture this and report to dev\n{}".format(e))

    def save_success_message(self):
        self.ui.saveLabel.setText("saved!")

    def clear_button_event(self):
        self.ui.saveLabel.setText("")
        self.ui.filename.setText("")
        self.ui.card_box.reset_data()
        self.ui.replaceImage_box.reset_data()

    def errorHandler(self):
        if self.card_path == "":
            QtWidgets.QMessageBox.warning(self, "Error", "import card")
            return False
        if self.replaceImage_path == "":
            QtWidgets.QMessageBox.warning(self, "Error", "import replace image")
            return False
        if self.ui.filename.text() == "":
            QtWidgets.QMessageBox.warning(self, "Error", "fill filename")
            return False
        return True


    def extract_image_event(self):
        if self.errorHandler():
            extract_only_image([self.card_path,self.replaceImage_path],None)

def resource_path(relative_path):
        """ Get absolute path to resource, works for dev and for PyInstaller """
        base_path = getattr(sys, '_MEIPASS', os.path.dirname(os.path.abspath(__file__)))
        return os.path.join(base_path, relative_path)
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