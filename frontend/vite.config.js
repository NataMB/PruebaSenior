import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

// Configuración para desarrollo y proxy a la API
export default defineConfig({
  plugins: [react()],
  server: {
    port: 3000,
    proxy: {
      '/api': 'http://localhost:5000'
    }
  }
})