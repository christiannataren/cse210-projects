class WareHouse
{
    private string[] _products = {
    "1|Milk|2.99",
    "2|Eggs(12pack)|3.49",
    "3|Bread|2.29",
    "4|Bananas(1lb)|0.69",
    "5|Apples(1lb)|1.29",
    "6|ChickenBreast(1lb)|4.99",
    "7|GroundBeef(1lb)|5.49",
    "8|Rice(2lb)|2.99",
    "9|Pasta|1.89",
    "10|TomatoSauce|1.49",
    "11|CheddarCheese(8oz)|3.79",
    "12|OrangeJuice(1L)|3.99",
    "13|Cereal|4.59",
    "14|Butter|3.49",
    "15|Yogurt|0.99"
};
    private string[] _customersList = {
    "John Doe|123 Main St|Springfield|Illinois|USA",
    "Jane Smith|456 Oak Ave|Greenville|Ontario|Canada",
    "Carlos Martinez|789 Maple Dr|Laketown|Jalisco|Mexico",
    "Emily Johnson|321 Cedar St|Rivertown|Kentucky|UK",
    "Michael Brown|654 Pine Ln|Sunnyvale|Bavaria|Germany",
    "Sarah Lee|987 Birch Blvd|Mapleton|Île-de-France|France",
    "David Clark|111 Elm St|Forestville|New South Wales|Australia",
    "Laura Wright|222 Ash Ct|Hillview|São Paulo|Brazil",
    "Daniel Lewis|333 Spruce Way|Brookfield|Lombardy|Italy",
    "Olivia Adams|444 Cherry Rd|Lakeside|Catalonia|Spain",
    "James Walker|555 Poplar Ave|Westport|Västra Götaland|Sweden",
    "Sophia Hall|666 Beech St|Easton|Buenos Aires|Argentina",
    "Benjamin Allen|777 Willow Dr|Northwood|Tokyo|Japan",
    "Emma Young|888 Magnolia Blvd|Southport|Maharashtra|India",
    "Alexander King|999 Cypress Ln|Clearwater|Gauteng|South Africa"
};

    private List<String[]> _availables;
    private List<String[]> _customers;
    public WareHouse()
    {
        _availables = ParseData(_products);
        _customers = ParseData(_customersList);

    }
    private List<string[]> ParseData(String[] info)
    {
        List<string[]> data = new List<string[]>();
        foreach (String line in info)
        {
            data.Add(line.Split("|"));
        }
        return data;
    }


    private Customer GetRandomCustomer()
    {
        String[] data = _customers[new Random().Next(_customers.Count())];
        return new Customer(data[0], new Address(data[1], data[2], data[3], data[4]));

    }
    private Product GetRandomProduct()
    {
        int election = new Random().Next(_availables.Count());
        String[] news = _availables[election];
        // Console.WriteLine(news.ToString());
        Double.TryParse(news[2], out double price);
        int quantity = new Random().Next(1, 7);
        int.TryParse(news[0], out int id);
        return new Product(id, news[1], price, quantity);
    }
    private List<Product> SelectRandomProducts()
    {
        List<Product> products = new List<Product>();
        // int randi = 1;
        int randi = new Random().Next(3, 10);
        for (int i = 0; i < randi; i++)
        {
            products.Add(GetRandomProduct());
        }
        return products;
    }

    public Order GetDummyOrder()
    {

        return new Order(GetRandomCustomer(), SelectRandomProducts());
    }

}