using Microsoft.AspNetCore.Mvc;
using TaskClient.Models;

namespace TaskClient.Controllers
{
    public class ClientController : Controller
    {
        public ClientDb ctx { get; set; }
        public ClientController(ClientDb ctx)
        {
            this.ctx = ctx;
        }
        public IActionResult ClientList(string name)
        {
            var mdl = new ClientListModel();
            mdl.ClientList = ctx.Clients.ToList();
            return View(name);
        }
        
        [HttpDelete]
        public ActionResult<Client> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var client = ctx.Clients.Find(id);
            if (client == null)
            {
                return NotFound();
            }
            ctx.Clients.Remove(client);
            ctx.SaveChanges();
            return RedirectToAction("ClientList");
        }        
        [HttpPost]
        public IActionResult Update(Client client)
        {
            if (client.Id == 0)
            {
                ctx.Clients.Add(client);
            }
            else
            {
                ctx.Attach(client);
                ctx.Entry(client).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            ctx.SaveChanges();
            return RedirectToAction("ClientList");
        }
        public IActionResult Update(string id)
        {
            Client mdl;
            int Id = 0;
            int.TryParse(id, out Id);
            if (Id == 0)
            {
                mdl = new();
            }
            else
            {
                mdl = ctx.Clients.Find(Id);
            }
            return View(mdl);
        }

        public IActionResult Index(string id, string name, string address, string phoneNumber, string cuit)
        {
            if (!string.IsNullOrEmpty(id))
            {
                int Id = 0;               
                if (int.TryParse(id,out Id))
                {
                    ctx.Clients.Add(new Client { Id=Id,Name=name, Address = address, PhoneNumber = phoneNumber, CUIT = cuit});
                    ctx.SaveChanges();
                }
            }
            return View();
        }
    }
}
