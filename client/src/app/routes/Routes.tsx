import { createBrowserRouter, Navigate } from "react-router-dom";
import App from "../layout/App";
import HomePage from "../../feature/home/HomePage";
import ProductDetails from "../../feature/catalog/ProductDetails";
import Catalog from "../../feature/catalog/Catalog";
import About from "../../feature/about/About";
import ContactPage from "../../feature/contact/ContactPage";
import ServerError from "../errors/ServerError";
import NotFound from "../errors/NotFound";
import BasketPage from "../../feature/basket/BasketPage";
import CheckoutPage from "../../feature/checkout/CheckoutPage";
import LoginForm from "../../feature/account/LoginForm";
import RegisterForm from "../../feature/account/RegisterForm";
import RequireAuth from "./RequireAuth";

export const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    children: [
      {
        element: <RequireAuth />,
        children: [{ path: "checkout", element: <CheckoutPage /> }],
      },
      { path: "", element: <HomePage /> },
      { path: "catalog", element: <Catalog /> },
      { path: "catalog/:id", element: <ProductDetails /> },
      { path: "about", element: <About /> },
      { path: "contact", element: <ContactPage /> },
      { path: "basket", element: <BasketPage /> },
      { path: "server-error", element: <ServerError /> },
      { path: "login", element: <LoginForm /> },
      { path: "register", element: <RegisterForm /> },
      { path: "not-found", element: <NotFound /> },
      { path: "*", element: <Navigate replace to={"/not-found"} /> },
    ],
  },
]);
