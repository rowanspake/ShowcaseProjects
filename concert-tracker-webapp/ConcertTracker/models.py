from django.db import models
from django import forms
import datetime


def present_or_future_date(value):
    if value < datetime.date.today():
        raise forms.ValidationError("The date cannot be in the past!")
    return value


class Concert(models.Model):
    concert_name = models.CharField(max_length=250, default="Artist")
    venue = models.CharField(max_length=250, default="Venue")
    concertDate = models.DateField(default=datetime.date.today, validators=[present_or_future_date])

    concerts = models.Manager()

    def __str__(self):
        return self.concert_name + ' at ' + self.venue


