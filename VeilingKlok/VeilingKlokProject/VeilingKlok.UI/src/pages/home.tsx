import { Container, Typography, Button, Stack, Box } from '@mui/material';
import { useNavigate } from 'react-router-dom';

export default function Home() {
    const navigate = useNavigate();
    return (
        <Box sx={{ bgcolor: '#f5f5f5', minHeight: '100vh', pt: 8 }}>
            <Container maxWidth="md" sx={{ textAlign: 'center' }}>

                <Typography variant="h2" component="h1" gutterBottom color="primary">
                    jemid Veiling
                </Typography>

                <Typography variant="h5" color="text.secondary" paragraph>
                    Welkom bij het realtime veilingplatform.
                    Maak een keuze om te beginnen.
                </Typography>

                <Stack direction="row" spacing={3} justifyContent="center" sx={{ mt: 5 }}>

                    <Button variant="contained"
                        size="large"
                        sx={{ px: 4, py: 1.5 }}
                        onClick={() => navigate('/klok')}>
                        Ik wil bieden
                    </Button>

                    <Button variant="outlined" size="large" sx={{ px: 4, py: 1.5 }}>
                        Veilingmeester
                    </Button>

                </Stack>

            </Container>
        </Box>
    );
}