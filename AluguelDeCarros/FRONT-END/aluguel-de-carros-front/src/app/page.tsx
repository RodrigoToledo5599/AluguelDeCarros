import Header from './components/Header/Header'
import TFD from './components/TryingToFetchData/TryingToFetchData'
import { Box, Container, Flex, SimpleGrid } from "@chakra-ui/layout";
import React from "react";
import Link from "next/link";
import { Button } from "@chakra-ui/react";

//import 'bootstrap/dist/css/bootstrap.min.css';
import './page.css'




export default function Home() {
  return (
    <body>
      <Header></Header>
      <div>
        <TFD idCarro={9} ></TFD>
      </div>
    </body>
  )
}
