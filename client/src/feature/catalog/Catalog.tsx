import { useEffect, useState } from "react";
import type { Product } from "../../app/models/product";
import ProductList from "./ProductList";

export default function Catalog() {
  const [products, setProducts] = useState<Product[]>([]);

  useEffect(() => {
    const fetchProducts = async () => {
      const response = await fetch("https://localhost:5001/api/products");
      const data = await response.json();
      setProducts(data);
    };

    fetchProducts();
  }, []);

  return (
    <>
      <ProductList products={products} />
    </>
  );
}
