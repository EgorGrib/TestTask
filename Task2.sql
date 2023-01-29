-- Запрос отношения many to many с помощью вспомогательной таблицы product_category
SELECT PRODUCT.NAME, CATEGORY.NAME
FROM PRODUCT LEFT JOIN product_category
ON product_category.PRODUCT_ID=PRODUCT.PRODUCT_ID
LEFT JOIN CATEGORY
ON product_category.CATEGORY_ID=CATEGORY.CATEGORY_ID

