--Products m-m Categories Products_Categories
SELECT ProdName, CatName
FROM Products_Categories
RIGHT JOIN Products
ON Products.Id = Products_Categories.ProdId
LEFT JOIN Categories 
on Categories.Id = Products_Categories.CatId 