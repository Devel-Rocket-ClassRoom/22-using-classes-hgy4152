using System;

// README.md를 읽고 아래에 코드를 작성하세요.

ProductInfo product1 = new ProductInfo("노트북", 1500000);
product1.PrintInfo();

ProductInfo product2 = new ProductInfo("키보드", 80000, 20);
product2.PrintInfo();

product2.DiscountPercent = 30;
product2.PrintInfo();


class ProductInfo
{ 
    public string Name { get; set; }
    public decimal Price { get; set; }

    public decimal DiscountPercent { get; set; } = 0;
    public decimal DiscountAmount { get { return (Price * (DiscountPercent / 100)); } }

    public decimal FinalPrice { get { return Price - DiscountAmount; } }


    public ProductInfo(string name, decimal price)
    {
        Name = name;
        Price = price;

    }

    public ProductInfo(string name, decimal price, decimal discountPercent)
    {
        Name = name;
        Price = price;
        DiscountPercent = discountPercent;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"[상품 정보] {Name} - 가격: {Price:n0}원, 할인: {DiscountPercent:n0}% (-{DiscountAmount:n0}원), 최종가: {FinalPrice:n0}원");
    }
}
