#! src/Scripts/python
import sys
from os import path as osPath ,getcwd as osGetcwd
from PyQt5 import QtCore, QtGui, QtWidgets
from module.utils import create_new_card,checkIsCharacterCard,checkIsCoordinateCard
from module.appUi import Ui_Form

class MyApp(QtWidgets.QMainWindow):
    def __init__(self, parent=None):
        QtWidgets.QWidget.__init__(self, parent)
        # init main window
        self.ui = Ui_Form()
        self.ui.setupUi(self)
        # init default data
        self.saveFilename = ''
        self.savePath = ''
        self.mode_selected = 'chara'
        # init button event
        self.ui.selectCard.clicked.connect(self.select_card_event)
        self.ui.selectReplaceImage.clicked.connect(self.select_replace_image_event)
        self.ui.saveBtn.clicked.connect(self.save_file)
        self.ui.saveAsBtn.clicked.connect(self.save_file_as)
        self.ui.clearBtn.clicked.connect(self.clear_button_event)
        self.ui.refreshFilenameBtn.clicked.connect(self.refreshFilename)
        self.ui.radioBtn_chara.clicked.connect(self.mode_change)
        self.ui.radioBtn_clothes.clicked.connect(self.mode_change)

    def select_card_event(self):
        selected_card,filters = QtWidgets.QFileDialog.getOpenFileName(None, 'Select card', filter="*png")
        if self.check_card_type(selected_card):
            self.ui.card.path = selected_card
            if self.ui.card.path != "":
                self.ui.saveLabel.setText("")
                filename, ext = osPath.splitext(self.ui.card.path.split('/')[-1])
                self.ui.filename.setText('new_{}'.format(filename))
                self.ui.card.set_image(self.ui.card.path)
            else:
                self.ui.filename.setText("")
                self.ui.saveLabel.setText("")
                self.ui.card.path = ""

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
            self.saveFilename = self.ui.filename.text() + '.png'
            dirs,filters = QtWidgets.QFileDialog.getSaveFileName(None, 'Save new card',osPath.join(osPath.dirname(self.ui.card.path), self.saveFilename), filter="*png")
            if dirs != "":
                self.savePath = dirs
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

    def refreshFilename(self):
        filename, ext = osPath.splitext(self.ui.card.path.split('/')[-1])
        self.ui.filename.setText('new_{}'.format(filename))

    def errorHandler(self):
        if self.ui.card.path == "":
            QtWidgets.QMessageBox.warning(self, "Error", "import card")
            return False
        if self.ui.replaceImage.path == "":
            QtWidgets.QMessageBox.warning(self, "Error", "import replace image")
            return False
        if self.ui.filename.text() == "":
            self.refreshFilename()
            if self.ui.card.path == "":
                QtWidgets.QMessageBox.warning(self, "Error", "fill filename")
                return False
        return True

    def mode_change(self):
        if self.ui.radioBtn_chara.isChecked():
            self.mode_selected = 'chara'
        elif self.ui.radioBtn_clothes.isChecked():
            self.mode_selected = 'clothes'

    def check_card_type(self,selected_card):
        print(self.mode_selected)
        if self.mode_selected == 'chara':
            if not checkIsCharacterCard(selected_card):
                QtWidgets.QMessageBox.warning(self, "Error", "This is not Character Card")
            else:
                return True
        elif self.mode_selected == 'clothes':
            if not checkIsCoordinateCard(selected_card):
                QtWidgets.QMessageBox.warning(self, "Error", "This is not Coordinate Card")
            else:
                return True

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