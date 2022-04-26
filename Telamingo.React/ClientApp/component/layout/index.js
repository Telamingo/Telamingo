import Header from "./header";


const Layout = (props) =>{
    return(
        <div>
            <Header isMobile={props.isMobile}/>
            {props.children}
        </div>
    )
}
export default Layout