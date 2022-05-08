import Header from "../layout/header/index";
import React from "react"


const Layout = (props) =>{

    return(
        <div>
            <Header isMobile={props.isMobile}/>
            {props.children}
        </div>
        // <div>
        //     <Header isMobile={props.isMobile}/>
        //     {props.children}
        // </div>
    )
}
export default Layout