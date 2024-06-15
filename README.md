# Task 2
![image](https://github.com/XxDominioNxX/Test/assets/92040109/2b0906c3-c907-4c3a-a654-500b26c513ce)
![image](https://github.com/XxDominioNxX/Test/assets/92040109/3a5521fb-db49-441f-be21-0c6690002821)

### Products
![image](https://github.com/XxDominioNxX/Test/assets/92040109/40e80eed-dc58-4575-867e-af4e842689eb)

### Categories
![image](https://github.com/XxDominioNxX/Test/assets/92040109/36e9b0b4-ec22-45ce-bba2-18e02fdb7115)

### Result
![image](https://github.com/XxDominioNxX/Test/assets/92040109/d6b79f25-8173-4d76-ad2b-f734de42c49c)

```
SELECT DISTINCT Products.Name, Categories.Name
from Products
	LEFT JOIN Categories ON Products.CategoryId = Categories.Id
```
