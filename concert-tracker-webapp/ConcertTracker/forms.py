from django.forms import ModelForm
from .models import Concert
from django import forms
import datetime


class ConcertForm(ModelForm):
    class Meta:
        model = Concert
        fields = '__all__'
        widgets = {
            'concertDate': forms.SelectDateWidget(),
        }
