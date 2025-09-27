using System;

namespace PersonalLib
{
    public class FunPredict
    {
        public string PredictBirthday(int day, int month, int year)
        {
            int seed = (day * month + year) % 5;
            switch (seed)
            {
                case 0: return "Ban la nguoi thich an pho.";
                case 1: return "Ban co kha nang lap trinh vao ban dem.";
                case 2: return "Ban cuc ky may man trong tinh cam.";
                case 3: return "Ban de thanh cong khi kien nhan.";
                default: return "Ban co to chat lam thay giao cong nghe.";
            }
        }
    }
}
