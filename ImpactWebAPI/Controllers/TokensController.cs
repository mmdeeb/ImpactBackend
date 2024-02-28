using ImpactDomain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ImpactWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokensController : ControllerBase
    {
        private readonly IConfiguration configuration;
        //حقن انترفايس الاعدادات
        public TokensController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        //رابط الوصول الى الكونترولر api/Tokens/auth
        [HttpPost("auth")]
        public ActionResult<string> authenticte()
        {
            //التحقق من وجود اليوزر "هنا هارد كودد"
            //تنفيذ الدالة موجود اسفل هذا الكود
            var user = ValidateUserCredentials();
            //اذا لم يجد اليوزر يعيد غير401 غير موثوق
            if (user == null)
                return Unauthorized();//401 Http status code
                                      //تشفير الكود السري الذي تم تمريره في ملف appsettings.json
            var mySecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["Authentiaction:Secret"]));
            //استخدام خوارزمية التشفيرHmacSha256 لتشفير الرمز السري 
            var mySigningCredentials = new SigningCredentials(mySecurityKey, SecurityAlgorithms.HmacSha256);
            //اضافة claims الى التوكين لزيادة التعقيد
            var claims = new List<Claim>();
            claims.Add(new Claim("sub", "1"));
            claims.Add(new Claim("given_name", "Shadi"));
            claims.Add(new Claim("family_name", "Assi"));
            //استخدمنا JWTلتوليد التوكين
            var myToken = new JwtSecurityToken(
            //الوصول الى Issuer في ملف appsettings.json
            configuration["Authentiaction:Issuer"],
            //الوصول الى Audience في ملف appsettings.json
            configuration["Authentiaction:Audience"],
            //تمرير مصفوفة الكلايمز التي انشاناها سابقا
            claims,
            //وقت الانشاء
            DateTime.UtcNow,
            //وقت صلاحية التوكين ساعة بعدها نحتاج توليد توكين جديد 
            DateTime.UtcNow.AddHours(1),
            //الرمز المشفر بالخوارزمية المحددة سابقا
            mySigningCredentials
            );
            //نعيد التوكين الذي توليده بعد ان نقوم بتحويله لنمط مقروء
            var serializedToken = new JwtSecurityTokenHandler().WriteToken(myToken);
            return Ok(serializedToken);//Http status code 200
        }


        //دالة التحقق من اسم المستخدم وكلمة المرور
        private User ValidateUserCredentials()
        {
            return new User("Shadi", "Assi");
        }
    }
    public class User
    {
        //باني
        public User(string username, string password)
        {
            UserName = username;
            Password = password;
        }


        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

