import FormQuestions from "../../component/FormQuestions";
import {useEffect, useState} from "react";
import Layout from "../../component/layout";


export default function Form(){

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
            <FormQuestions isMobile={isMobile}/>
            </Layout>
        </div>
    )
}