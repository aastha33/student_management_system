using student_management.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace student_management.Controllers
{
    public class NotificationController : Controller
    {
        // GET: Notification
        INotiService _notiService = null;
        List<Models.notification> _oNotifications = new List<Models.notification>();

        public NotificationController(INotiService notiService)
        {
            _notiService = notiService;
        }
        public ActionResult AllNotifications()
        {
            return View();
        }

        public JsonResult GetNotifications(bool bIsGetOnlyUnread=false)
        {
            int nToUserId = 2;
            _oNotifications = new List<Models.notification>();
            _oNotifications = _notiService.GetNotifications(nToUserId, bIsGetOnlyUnread);
            return Json(_oNotifications);
                
        }
    }
}