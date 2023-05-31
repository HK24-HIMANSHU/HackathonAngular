using static HotelWithMenu.Models.Resturant;

namespace HotelWithMenu.Models
{
    public class DataComponents
    {
        AngularDB context = new AngularDB();
        public bool AddItems(Resturant resturant)
        {
            var empList = context.Resturants.ToList();
            try
            {
                empList.Add(resturant);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool DeleteItem(int id)
        {
            var ItemList = context.Resturants.ToList();
            try
            {
                var emp = context.Resturants.FirstOrDefault(e => e.id == id);
                if (emp != null)
                {
                    ItemList.Remove(emp);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void UpdateItem(Resturant resturant)
        {
            var empList = context.Resturants.ToList();
            var foundUpdate = context.Resturants.FirstOrDefault(e => e.id == resturant.id);
            if (foundUpdate != null)
            {
                context.Remove(foundUpdate);
                context.Add(resturant);
                context.SaveChanges();
            }

        }

        public List<Resturant> Show()
        {
            return context.Resturants.ToList();
        }

    }
}
