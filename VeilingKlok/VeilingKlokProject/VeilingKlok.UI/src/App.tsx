import { CssBaseline } from '@mui/material';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Home from './pages/home'
import AuctionClock from './pages/AuctionClock';

function App() {
    return (
        <BrowserRouter>
            <CssBaseline /> 
            <Routes>
                <Route path="/" element={<Home />} />
                <Route path="/klok" element={<AuctionClock />} />
            </Routes>
        </BrowserRouter>
    );
}

export default App;