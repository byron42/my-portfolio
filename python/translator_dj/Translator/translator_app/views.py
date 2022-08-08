from django.shortcuts import render
from googletrans import Translator
from django.http import HttpResponse

# Create your views here.
def home(request):
    return render(request,'home.html')
    # return  HttpResponse()

def translated(request):
    text = request.GET.get('text')
    lang = request.GET.get('lang')
    print(text, lang)

    # translate the text
    translator = Translator()

    # detect entered lang
    dt = translator.detect(text)
    dt2 = dt.lang

    # translate text
    translated = translator.translate(text, lang)

    tr = translated.text
    return render(request, 'translated.html', {'translated':tr, 'u_lang':dt2, 't_lang':lang})