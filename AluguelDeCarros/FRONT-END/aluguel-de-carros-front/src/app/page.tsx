import Header from './components/Header/Header'
import TFD from './components/TryingToFetchData/TryingToFetchData'
import { Box, Container, Flex, SimpleGrid } from "@chakra-ui/layout";
import React from "react";
import Link from "next/link";
import { Button } from "@chakra-ui/react";

export default function Home() {
  return (
    <main>
    
      <h1>Carro:</h1>
      <TFD></TFD>
    </main>
  )
}
