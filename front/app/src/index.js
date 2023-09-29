import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import Produtos from './Produtos';
import Garantia from './Garantias';
import Vendas from './Vendas';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter, Routes, Route } from 'react-router-dom'

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <BrowserRouter>
    <Routes>
      <Route  path="/Vendas" component={<Vendas />} />
      <Route  path="/Produtos" component={<Produtos />} />
      <Route  path="/Garantia" component={<Garantia />} />
    </Routes>
        <React.StrictMode>
          <App />
        </React.StrictMode>
  </BrowserRouter>
);
reportWebVitals();
