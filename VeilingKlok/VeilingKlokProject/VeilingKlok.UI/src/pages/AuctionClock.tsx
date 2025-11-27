import { Container, Card, CardMedia, CardContent, Typography, Button, Box, Paper } from '@mui/material';

export default function AuctionClock() {
    return (
        <Container maxWidth="sm" sx={{ mt: 4 }}>
            <Paper elevation={3} sx={{ p: 2, mb: 2, textAlign: 'center', bgcolor: '#e3f2fd' }}>
                <Typography variant="h6">
                    Veiling status: 🟢 Live
                </Typography>
            </Paper>

            <Card sx={{ maxWidth: 600 }}>
                
                <CardMedia
                    component="img"
                    height="300"
                    image="https://placehold.co/600x400/FF69B4/white?text=moet_nog_fotos_in_db_adden_:)"
                    alt="Bloem"
                />
                <CardContent>
                    <Typography gutterBottom variant="h5" component="div">
                        aantal stuks moet hier te komen staan, nog niet geadd in db
                    </Typography>
                    <Typography variant="body2" color="text.secondary" gutterBottom>
                        "bedrijf dat het verkoopt // moet ik nog toevoegen aan de db"
                    </Typography>

                    
                    <Box sx={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', mt: 4, p: 2, bgcolor: '#f5f5f5', borderRadius: 1 }}>
                        <Box>
                            <Typography variant="caption">Huidige prijs:</Typography>
                            <Typography variant="h3" color="primary" sx={{ fontWeight: 'bold' }}>
                                € 14,50
                            </Typography>
                        </Box>

                        <Button variant="contained" color="success" size="large" sx={{ px: 4, py: 2, fontSize: '1.2rem' }}>
                            KOOP NU 
                        </Button>
                    </Box>
                </CardContent>
            </Card>
        </Container>
    );
}