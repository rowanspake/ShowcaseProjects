from django.urls import path
from . import views

urlpatterns = [
    path('add_concert/', views.add_concert, name='addConcert'),
    path('', views.concerttracker_home, name='concerttracker_home'),
    path('upcoming_concerts/', views.upcoming_concerts, name='upcomingConcerts'),
    path('my_concerts/', views.my_concerts, name='my_concerts'),
    path('<int:pk>/concert_details/', views.concert_details, name='concert_details'),

]