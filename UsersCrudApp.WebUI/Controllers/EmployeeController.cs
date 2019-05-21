using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsersCrudApp.WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index(string message)
        {
           
            return View(new UsersMgt.UsersHandler().GetUsers().ToViewModels());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Models.UserModel model)
        {
            var r = new UsersMgt.UsersHandler().AddUser(model.toDataModel());
            Models.AlertModel alertModel = new Models.AlertModel("User Add Operation Failed", "danger"); ;
            if (r != null)
            {
                alertModel = new Models.AlertModel(r.FullName + " is added succerssfully", "success");
            }
            TempData.Add("alert", alertModel);
            return RedirectToAction("index");
        }

        public ActionResult Update(int Id)
        {
            return View(new UsersMgt.UsersHandler().GetUser(Id).ToViewModel());
        }
        [HttpPost]
        public ActionResult Update(Models.UserModel model)
        {
            var r = new UsersMgt.UsersHandler().UpdateUser(model.Id, model.toDataModel());
            Models.AlertModel alertModel = new Models.AlertModel("User Update Operation Failed", "danger"); ;
            if (r != null)
            {
                alertModel = new Models.AlertModel(r.FullName + " is updated succerssfully", "success");

            }
            TempData.Add("alert", alertModel);
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Remove(int id)
        {
            var r = new UsersMgt.UsersHandler().RemoveUser(id).ToViewModel();
            Models.AlertModel alertModel = new Models.AlertModel("User Remove Operation Failed", "danger"); ;
            if (r != null)
            {
                alertModel = new Models.AlertModel(r.FullName + " is removed", "success");
            }
            TempData.Add("alert", alertModel);
            return RedirectToAction("index");
        }
    }
}