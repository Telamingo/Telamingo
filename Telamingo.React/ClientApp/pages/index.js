import {useEffect, useState} from "react";

import Layout from "../component/layout";
import HomePage from "../component/HomePage";

export default function Home(props) {

    const [isMobile, setIsMobile] = useState(false)

    useEffect(() => {
        window.addEventListener("resize", handleResize)
    })

    const handleResize = () => {
        if (window.innerWidth < 720) {
            setIsMobile(true)
        } else {
            setIsMobile(false)
        }
    }

  return (
    <div>
        <Layout isMobile={isMobile}>
            <HomePage  isMobile={isMobile}/>
        </Layout>
    </div>
  )
}

