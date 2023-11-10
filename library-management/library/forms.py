from django import forms
from django.contrib.auth.models import User
from . import models

class ContactusForm(forms.Form):
    Name = forms.CharField(max_length=30)
    Email = forms.EmailField()
    Message = forms.CharField(max_length=500,widget=forms.Textarea(attrs={'rows': 3, 'cols': 30}))




class AdminSigupForm(forms.ModelForm):
    class Meta:
        model=User
        fields=['first_name','last_name','username','password']
        labels = {
            'first_name': 'Аты',
            'last_name': 'Тегі',
            'username': 'Пайдаланушы аты',
            'password': 'Құпия сөз'
        }



class StudentUserForm(forms.ModelForm):
    class Meta:
        model=User
        fields=['first_name','last_name','username','password']
        labels = {
            'first_name': 'Аты',
            'last_name': 'Тегі',
            'username': 'Пайдаланушы аты',
            'password': 'Құпия сөз'
        }

class StudentExtraForm(forms.ModelForm):
    class Meta:
        model=models.StudentExtra
        fields=['enrollment','branch']
        labels = {
            'enrollment': 'Тіркелу номері',
            'branch': 'Билет типі'
        }

class BookForm(forms.ModelForm):
    class Meta:
        model=models.Book
        fields=['name','isbn','author','category']
        labels = {
            'name': 'Аты',
            'isbn': 'Жеке номері',
            'author': 'Авторы',
            'category': 'Категория'
        }

class IssuedBookForm(forms.Form):
    isbn2 = forms.ModelChoiceField(queryset=models.Book.objects.all(), empty_label="Атау және номері", to_field_name="isbn", label='Атау және номері')
    enrollment2 = forms.ModelChoiceField(queryset=models.StudentExtra.objects.all(), empty_label="Атауы және тіркелу нөмірі", to_field_name='enrollment', label='Атауы және тіркелу нөмірі')
