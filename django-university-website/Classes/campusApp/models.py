from django.db import models

# Create your models here.


class UniversityCampus(models.Model):
    campus_name = models.CharField(max_length=100, default="", blank=True, null=False)
    location_state = models.CharField(max_length=2, default="", blank=True, null=False)
    campus_id = models.IntegerField(default="", blank=True, null=False)

    object = models.Manager()

    def __str__(self):
        display_campus = '{0.campus_name} campus'
        return display_campus.format(self)

    class Meta:
        verbose_name_plural = "University Campus"
