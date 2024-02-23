from django.shortcuts import render, redirect
from django.http import JsonResponse
from characterai import PyCAI
import os

from django.contrib import auth
from django.contrib.auth.models import User
from .models import Chat

from django.utils import timezone

# Настройка клиента Character AI
client = PyCAI('d2dc75bfecddbc48834d7fda4ac2fd304fd6565f')

def ask_character_ai(char, message):
    try:
        chat = client.chat.get_chat(char)
        participants = chat['participants']

        if not participants[0]['is_human']:
            tgt = participants[0]['user']['username']
        else:
            tgt = participants[1]['user']['username']

        # Отладочный вывод для ответа от API
        print(f"Sending message to {tgt} in chat {chat['external_id']}")

        response = client.chat.send_message(chat['external_id'], tgt, message)
        print("Response received:", response)  # Это должно показать фактический ответ от API

        reply_text = response['replies'][0]['text']

        return reply_text.strip()
    except Exception as e:
        print("Exception occurred:", e)  # Это покажет исключение, если оно произойдёт
        return str(e)

def homepage(request):
    return render(request, 'main.html')

# Create your views here.
def chatbot(request):
    chats = Chat.objects.filter(user=request.user)

    if request.method == 'POST':
        message = request.POST.get('message')
        char = 'nuAflQnxUKPT3jWNYpEaHBgAlODB8sgOPx-y-l_-77A'  # Укажите здесь ID вашего CHAR
        response = ask_character_ai(char, message)

        chat = Chat(user=request.user, message=message, response=response, created_at=timezone.now())
        chat.save()
        return JsonResponse({'message': message, 'response': response})
    return render(request, 'chatbot.html', {'chats': chats})

def login(request):
    if request.method == 'POST':
        username = request.POST['username']
        password = request.POST['password']
        user = auth.authenticate(request, username=username, password=password)
        if user is not None:
            auth.login(request, user)
            return redirect('chatbot')
        else:
            error_message = 'Invalid username or password'
            return render(request, 'login', {'error_message': error_message})
    else:
        return render(request, 'login.html')

def register(request):
    if request.method == 'POST':
        username = request.POST['username']

        email = request.POST['email']
        password1 = request.POST['password1']
        password2 = request.POST['password2']

        if password1==password2:
            try:
                user = User.objects.create_user(username, email, password1)
                user.save()
                auth.login(request, user)
                return redirect('chatbot')
            except:
                error_message = 'Error creating account'
                return render(request, 'register.html', {'error_message': error_message})
        else:
            error_message = 'Password dont match'
            return render(request, 'register.html', {'error_message': error_message})
    return render(request, 'register.html')

def logout(request):
    auth.logout(request)
    return redirect('homepage')