using ASM_FINAL.Models;
using Newtonsoft.Json;

namespace ASM_FINAL.Services
{
    public static class SessionServices
    {
        // đọc dữ liệu từ session trả về 1 list
        public static List<Product> GetObjFromSession(ISession session, string key)
        {
            string jsonData = session.GetString(key);//lấy dữ liệu từ string từ session
            if (jsonData == null)
            {
                return new List<Product>();//khởi tạo 1 list mới chứa sp khi dữ liệu lấy ra null <=> session chưa được tạo ra -> lần đầu
            }
            else
            {
                var products = JsonConvert.DeserializeObject<List<Product>>(jsonData);//nếu dữ liệu có chuyển đổi về dạng list
                return products;
            }
        }
        // ghi đè dữ liệu từ session từ 1 list
        public static void SetObjToSession(ISession session, string key, object data)
        {
            var jsonData = JsonConvert.SerializeObject(data);// chuyển đổi dữ liệu về json data
            session.SetString(key, jsonData);//ghi đè vào session
        }
        // kiểm tra 1 đối tượng có nằm trong 1 list hay ko
        public static bool CheckObjInList(Guid id, List<Product> products)
        {
            return products.Any(p => p.Id == id);
        }
    }
}
