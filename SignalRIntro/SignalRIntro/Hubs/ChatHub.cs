using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using SignalRIntro.Data;
using SignalRIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRIntro.Hubs
{
    public class ChatHub : Hub
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public ChatHub(AppDbContext context,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task SendMessage(string user, string message)
        {
            await Clients.Others.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SendPrivateMessage(string recieverid, string senderid, string message)
        {
            await Clients.User(recieverid).SendAsync("ReceivePrivateMessage", senderid, message);

            Message newMessage = new Message();
            newMessage.Text = message;
            newMessage.CreatedDate = DateTime.Now;
            newMessage.SenderId = senderid;
            newMessage.RecieverId = recieverid;

            _context.Messages.Add(newMessage);
            _context.SaveChanges();
        }
    }
}
