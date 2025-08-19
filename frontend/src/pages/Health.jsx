import React, { useEffect, useState } from 'react'

export default function Health() {
  const [status, setStatus] = useState("Cargando...")

  useEffect(() => {
    fetch("http://localhost:5000/health")
      .then(res => {
        if (res.ok) return setStatus("✅ API OK")
        throw new Error("Error en API")
      })
      .catch(() => setStatus("❌ API NO DISPONIBLE"))
  }, [])

  return (
    <div className="mt-4 p-4 border rounded bg-white shadow">
      <h2 className="text-xl font-semibold">Estado de la API</h2>
      <p className="mt-2">{status}</p>
    </div>
  )
}