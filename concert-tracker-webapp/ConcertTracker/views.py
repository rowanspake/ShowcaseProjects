from django.shortcuts import render, redirect, get_object_or_404
from .forms import ConcertForm
from .models import Concert
from django.forms import ModelForm
import requests
import json
from bs4 import BeautifulSoup


def concerttracker_home(request):
    return render(request, 'ConcertTracker/index.html')


def add_concert(request):
    form = ConcertForm(data=request.POST or None)
    content = {'form': form}
    if request.method == 'POST':
        if form.is_valid():
            form.save()
            return redirect('my_concerts')
    return render(request, 'ConcertTracker/add_concert.html', content)


def upcoming_concerts(request, pk):
    return render(request, 'ConcertTracker/upcoming_concerts.html')


def my_concerts(request):
    info = Concert.concerts.all()
    context = {'info': info}
    return render(request, 'ConcertTracker/my_concerts.html', context)


def concert_details(request, pk):
    item = get_object_or_404(Concert, pk=pk)
    context = {'item': item}
    return render(request, 'ConcertTracker/concert_details.html', context)


