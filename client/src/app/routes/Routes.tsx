import { createBrowserRouter } from "react-router-dom";
import App from "../layout/App";
import HomePage from "../../feature/home/HomePage";
import ProductDetails from "../../feature/catalog/ProductDetails";
import Catalog from "../../feature/catalog/Catalog";
import About from "../../feature/about/About";
import ContactPage from "../../feature/contact/ContactPage";

export const router = createBrowserRouter([
    {
        path: '/',
        element: <App />,
        children: [
            { path: '', element: <HomePage /> },
            { path: '/catalog', element: <Catalog /> },
            { path: '/catalog/:id', element: <ProductDetails /> },
            { path: '/about', element: <About /> },
            { path: '/contact', element: <ContactPage/>},
        ]
    }
])