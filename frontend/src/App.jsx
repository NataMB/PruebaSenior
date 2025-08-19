import React from 'react'
import Health from './pages/Health'

export default function App() {
  return (
    <div className="p-6">
      <h1 className="text-3xl font-bold text-blue-600">Prueba Senior - Frontend</h1>
      <p className="mt-2 text-gray-700">Consumiendo API en Docker</p>
      <Health />
    </div>
  )
}