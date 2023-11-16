import Header from './components/Header/Header'
import Car from './components/CarOnMainMenu/CarOnMainMenu'
import { Box, Container, Flex, SimpleGrid } from "@chakra-ui/layout";
import React from "react";
import Link from "next/link";
import { Button } from "@chakra-ui/react";
import CarsCollection from './components/CarsCollection/CarsCollection';


//import 'bootstrap/dist/css/bootstrap.min.css';
import './page.css'




export default function Home() {
  return (
    <body>
      <Header></Header>

        <div className='page-Content'>
          <CarsCollection comeco= {3} fim={10}></CarsCollection>
          
        </div>
    </body>
  )
}
