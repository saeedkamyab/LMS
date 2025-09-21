using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Constants.MessageText
{
    public class ResponseMessageText
    {
        public const string FAILD_SAVING = "ذخیره با خطا مواجه شد.";
        public const string SUCCESSFUL_SAVING = "با موفقیت ثبت شد";

        public const string FAILD_UPDATING = "ویرایش با خطا مواجه شد";
        public const string SUCCESSFUL_UPDATING = "با موفقیت ویرایش شد";

        public const string FAILD_DELETING = "حذف با خطا مواجه شد";
        public const string SUCCESSFUL_DELETING = "با موفقیت حذف شد";

        public const string DUPLICATED_RECORD = "امکان ثبت رکورد تکراری وجود ندارد. لطفا مجدد تلاش بفرمایید.";
        public const string RECORD_NOT_FOUND = "رکورد با اطلاعات درخواست شده یافت نشد. لطفا مجدد تلاش بفرمایید.";

        public const string PASSWORD_NOT_MATCH = "پسورد و تکرار آن با هم مطابقت ندارند";
        public const string WRONG_USER_PASS = "نام کاربری یا کلمه رمز اشتباه است";
    }
}
