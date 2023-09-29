import Container from '../../node_modules/react-bootstrap/Container';
import Nav from '../../node_modules/react-bootstrap/Nav';
import Navbar from '../../node_modules/react-bootstrap/Navbar';
import NavDropdown from '../../node_modules/react-bootstrap/NavDropdown';
import { Outlet, Link} from 'react-router-dom'

function Main ()  {
    return(
        <Navbar expand="lg" className="bg-body-tertiary">
            <Container>
                <Navbar.Brand href="#home">Gerenciador</Navbar.Brand>
                <Navbar.Toggle aria-controls="basic-navbar-nav" />
                <Navbar.Collapse id="basic-navbar-nav">
                <Nav className="me-auto">
                    <Nav.Link href="#home">Home</Nav.Link>
                    <NavDropdown title="Gerenciar" id="basic-nav-dropdown">
                    <NavDropdown.Item href="Produtos">Produtos</NavDropdown.Item>
                    <NavDropdown.Item href="#action/Garantias">Garantia</NavDropdown.Item>
                    <NavDropdown.Item href="#action/Vendas">Vendas</NavDropdown.Item>
                    </NavDropdown>
                </Nav>
                </Navbar.Collapse>
            </Container>
    </Navbar>
    )
}

export default Main;