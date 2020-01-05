using AddressBook.Component;
using AddressBook.Dto;
using AddressBook.Dto.PubEnum;
using AddressBook.Web.Filter;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddressBook.Web.Controllers
{
    public class HomeController : Controller
    {
        [BookAuth]
        public ActionResult Index()
        {
            //判断是否开启自动识别PC端和移动端
            bool EnableAutoUrl = System.Configuration.ConfigurationSettings.AppSettings["EnableAutoUrl"].ToString().ToBool();
            String requestHeader = Request.Headers["user-agent"];
            if (EnableAutoUrl && IsMobileDevice(requestHeader))
            {
                //APP端
                string appUrl = System.Configuration.ConfigurationSettings.AppSettings["APPUrl"].ToString();
                return Redirect(appUrl);
            }
            ////ERP端
            //if (!ZiXin.Web.Component.MVC.LoginUserManager.IsLogin)
            //{
            //    return RedirectToRoute(new { controller = "Login", action = "Index" });
            //}
            return View();
        }

        /// <summary>
        /// 判断是不是移动端
        /// </summary>
        /// <param name="requestHeader"></param>
        /// <returns></returns>
        public static bool IsMobileDevice(String requestHeader)
        {
            /**
             * android : 所有android设备
             * mac os : iphone ipad
             * windows phone:Nokia等windows系统的手机
             */
            String[] deviceArray = new String[] { "240x320","acer","acoon","acs-","abacho","ahong","airness","alcatel","amoi",
        "android","anywhereyougo.com","applewebkit/525","applewebkit/532","asus","audio",
        "au-mic","avantogo","becker","benq","bilbo","bird","blackberry","blazer","bleu",
        "cdm-","compal","coolpad","danger","dbtel","dopod","elaine","eric","etouch","fly ",
        "fly_","fly-","go.web","goodaccess","gradiente","grundig","haier","hedy","hitachi",
        "htc","huawei","hutchison","inno","ipad","ipaq","iphone","ipod","jbrowser","kddi",
        "kgt","kwc","lenovo","lg ","lg2","lg3","lg4","lg5","lg7","lg8","lg9","lg-","lge-","lge9","longcos","maemo",
        "mercator","meridian","micromax","midp","mini","mitsu","mmm","mmp","mobi","mot-",
        "moto","nec-","netfront","newgen","nexian","nf-browser","nintendo","nitro","nokia",
        "nook","novarra","obigo","palm","panasonic","pantech","philips","phone","pg-",
        "playstation","pocket","pt-","qc-","qtek","rover","sagem","sama","samu","sanyo",
        "samsung","sch-","scooter","sec-","sendo","sgh-","sharp","siemens","sie-","softbank",
        "sony","spice","sprint","spv","symbian","tablet","talkabout","tcl-","teleca","telit",
        "tianyu","tim-","toshiba","tsm","up.browser","utec","utstar","verykool","virgin",
        "vk-","voda","voxtel","vx","wap","wellco","wig browser","wii","windows ce",
        "wireless","xda","xde","zte" };
            if (requestHeader == null)
                return false;
            requestHeader = requestHeader.ToLower();
            for (int i = 0; i < deviceArray.Count(); i++)
            {
                if (requestHeader.IndexOf(deviceArray[i]) > 0)
                {
                    return true;
                }
            }
            return false;
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [BookAuth]
        [HttpPost]
        public ActionResult Login(Models.Home.UIModel_Login model)
        {
            EcdrpSite ecdrpSite = EcdrpSite.Admin;
            LoginEnum result =LoginEnum.Empty;
            bool IsValid = false;
            IBLL.IBase_UserManager u = new BLL.Base_UserManager();
            if (!string.IsNullOrEmpty(model.CheckCode) && model.CheckCode.Equals(Session["ValidateCode"] ?? ""))
            {
                IsValid = true;
            }
            if (IsValid)
            {
                LoginInputDto input = new LoginInputDto();  //参数实体
                input.UserName = model.accountName;  //用户名
                input.UserPwd = model.password;    //密码
                
                input.IP = HttpRequestHelper.GetIP(this.Request); //登录IP地址
                input.Browser = HttpRequestHelper.GetBrowser(this.Request); //浏览器版本号
                result = u.Login(input, out ecdrpSite);
                //验证测试系统是否存在自动上传
                //var obj = new ZiXin.ERP.PublicModels.PublicData().CheckAutoUpload();
                //if (obj.Tag == -1)
                //{//测试系统中存在自动上传功能
                //    result = -9;
                //}
            }
            else
            {
                result= LoginEnum.CheckCodeErr;  //验证码错误，返回9
            }

            return Json(new { result = result, site = ecdrpSite.ToString(), par = System.Web.HttpUtility.UrlEncode(model.accountName) });
        }
        /// <summary>
        /// 验证码
        /// </summary>
        /// <returns></returns>
        public ActionResult GetValidateCode()
        {
            ValidateCode vCode = new ValidateCode();
            string code = vCode.CreateValidateCode(4);//生成后的验证码
            Session["ValidateCode"] = code;//加入浏览器缓存
            byte[] bytes = vCode.CreateValidateGraphic(code);
            return File(bytes, @"image/jpeg");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}