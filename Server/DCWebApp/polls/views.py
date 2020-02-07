from django.shortcuts import render

# Create your views here.
from django.http import HttpResponse

from polls.models import GUser

import uuid, json

def index(request):
    return HttpResponse("Hello, world. You're at the polls index.")

def add_user(request):
    request.encoding='utf-8'
    if 'user_name' in request.POST and request.POST['user_name'] and 'user_psw' in request.POST and request.POST['user_psw']:
        user_name = request.POST['user_name']
        user_psw = request.POST['user_psw']

        loginUsers = GUser.objects.filter(u_name=user_name,u_psw=user_psw)
        if loginUsers.count() == 0:
            token = uuid.uuid4().hex
            newUser = GUser(u_name=user_name, u_psw = user_psw, u_token = token)
            newUser.save()
            result = {'result':'1','token':token}
            return HttpResponse(json.dumps(result))
        else:
           return HttpResponse(json.dumps({'result':'2'}))
    return HttpResponse(json.dumps({'result':'0'}))

def login(request):
    if 'user_name' in request.GET and request.GET['user_name'] and 'user_psw' in request.GET and request.GET['user_psw']:
        user_name = request.GET['user_name']
        user_psw = request.GET['user_psw']
        loginUsers = GUser.objects.filter(u_name=user_name,u_psw=user_psw)
        if loginUsers.count() > 0:
            loginUser = loginUsers[0]
            print(loginUser.u_name, loginUser.u_psw)
            result = {'result':'1','token': loginUser.u_token}
            return HttpResponse(json.dumps(result))

    return HttpResponse(json.dumps({'result':'0'}))
