import logo from './logo.svg';
import './App.css';
import Main from './components/mainApp'
import 'bootstrap/dist/css/bootstrap.min.css';
import Vendas from './Vendas'
import {BrowserRouter, Routes, Router} from 'react-router-dom'

function App() {
  return (
    <div className="App">
      <Main />
    </div>
  );
}

export default App;
