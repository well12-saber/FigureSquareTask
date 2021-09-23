select product.name,category.name
from product 
join productCategory on product.id=productCategory.productId
join category on category.Id=productCategory.categoryId
UNION
select product.name,null
from product 
where product.id not IN (select productId from productCategory)
