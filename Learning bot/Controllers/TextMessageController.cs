﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Learning_bot.Controllers
{
    public class TextMessageController
    {
        private readonly ITelegramBotClient _telegramClient;

        public TextMessageController(ITelegramBotClient telegramBotClient)
        {
            _telegramClient = telegramBotClient;
        }
        public async Task Handle(Message message, CancellationToken ct)
        {
            Console.WriteLine($"Контроллер {GetType().Name} получил сообщение от {message.From.Id.ToString()}");
            await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Получено текстовое сообщение", cancellationToken: ct);
        }
    }
}   
