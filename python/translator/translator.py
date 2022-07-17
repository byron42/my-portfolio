from tkinter import *
import googletrans
import textblob
from tkinter import ttk, messagebox


root = Tk()
root.title('Language Translator')
root.iconbitmap('')
root.geometry("880x300")

def translate_it():

    # clear previous input
    translated_text.delete(1.0, END)

    try:
        #------------------------------------------------- GET LANGS FROM KEYS

        # (( from ))
        for key, value in languages.items():
            if (value == original_combo.get()):
                from_language_key = key

        # (( to ))
        for key, value in languages.items():
            if (value == translated_combo.get()):
                to_language_key = key
                
        #---------------------------------------------------------------------

        # turn input into textblob object
        words = textblob.TextBlob(original_text.get(1.0, END))

        # translation
        words = words.translate(from_lang=from_language_key , to=to_language_key)
        
        # output to translated box
        translated_text.insert(1.0, words)
        
    except Exception as e:
        messagebox.showerror("translator", e)

def clear():
    # clear boxes
    original_text.delete(1.0, END)
    translated_text.delete(1.0, END)

# GET LANGUAGE LIST FROM TRANS
languages = googletrans.LANGUAGES

# CONVERT TO A LIST
language_list = list(languages.values())

# TEXT BOXES
original_text = Text(root, height=10, width=40, bg="#fff")
original_text.grid(row=0, column=0, pady=20, padx=10)

translate_button = Button(root, text="Translate!", font=("Helvetica", 24), command=translate_it)
translate_button.grid(row=0, column=1, padx=10)

translated_text = Text(root, height=10, width=40)
translated_text.grid(row=0, column=2, pady=20, padx=10)

#COMBO BOXES
original_combo = ttk.Combobox(root, width=50, value=language_list)
original_combo.current(21)
original_combo.grid(row=1, column=0)

translated_combo = ttk.Combobox(root, width=50, value=language_list)
translated_combo.current(26)
translated_combo.grid(row=1, column=2)

#CLEAR BUTTON
clear_button = Button(root, text="Clear", command=clear)
clear_button.grid(row=2, column=1)

root.mainloop()

