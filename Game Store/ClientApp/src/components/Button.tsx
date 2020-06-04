import React, { useEffect } from 'react';

export const Button = () => {

    useEffect(() => {
        const getData = async () => {
            const response = await fetch('https://localhost:44351/api/game')
                .then(response => response.json())
                .then(data => console.log(data));
            
        }
        getData();
    }, [])
    return <button>Request</button>
}