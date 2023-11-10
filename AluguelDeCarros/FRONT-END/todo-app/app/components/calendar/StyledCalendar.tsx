'use client'
import React, { useState } from 'react';
import Calendar from 'react-calendar';
import './styleOriginal.css';


const StyledCalendar = () => {
  const [isOpen, setIsOpen] = useState(false);

  const toggleCalendar = () => {
    setIsOpen(!isOpen);
  };

  return (
    <div>
      <button onClick={toggleCalendar}>this.nome</button>
      {isOpen && (
        <div className="calendar">
          <Calendar />
        </div>
      )}
    </div>
  );
};

export default StyledCalendar;