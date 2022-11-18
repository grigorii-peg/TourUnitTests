using Last_min_Tour.Models;

namespace TourUnit
{
    public class TourBusiness
    {
            private List<Tour> tours = new List<Tour>();

            public TourBusiness() { }
            public List<Tour> GetList()
            {
                return tours;
            }
            public void Add(Tour data)
            {
                tours.Add(data);
            }
            public void Edit(Tour id, Tour data)
            {
                var index = tours.IndexOf(id);
                tours[index] = data;
            }
            public void Delete(Tour data)
            {
                tours.Remove(data);
            }
        }
    }
