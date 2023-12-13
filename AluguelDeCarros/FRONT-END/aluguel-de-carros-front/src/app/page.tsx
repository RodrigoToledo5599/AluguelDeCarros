import Header from './components/Header/Header'
import { Box, Container, Flex, SimpleGrid } from "@chakra-ui/layout";
import Link from "next/link";
import { Button } from "@chakra-ui/react";
import CarsCollection from './components/CarsCollection/CarsCollection';
import { FaLongArrowAltLeft,FaLongArrowAltRight } from "react-icons/fa";


//import 'bootstrap/dist/css/bootstrap.min.css';
import './page.css'



export default function Home() {
  return (
    <body>
      <Header></Header>

        <div className='page-Content'>
          <CarsCollection comeco= {0} fim={9}></CarsCollection>
        
        </div>
    </body>
  )
}
