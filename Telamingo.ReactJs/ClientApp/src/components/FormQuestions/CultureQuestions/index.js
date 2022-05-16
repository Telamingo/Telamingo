import React, {useState} from "react";
import style from "./cultureQuestion.module.css";
import HealthQuestion from "../HealthQuestion";

const CultureQuestions = (props) =>{

    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [thirdQuestion, setThirdQuestion] = useState(false);
    const [forthQuestion, setForthQuestion] = useState(false);
    const [cultureAnswer, setCultureAnswer] = useState("");

    const setAnswer=(answer)=>{
        setCultureAnswer([...cultureAnswer,answer])
    }

    console.log(cultureAnswer)

    return(
        <React.Fragment>
            {
                !forthQuestion ?
                    <div className={` col-lg-12 ${style.questionBody}`}>
                        <div className={`${style.questionContent} mt-5`} dir='ltr'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                How important are religious issues to you and do you adhere to them?
                                            </p>
                                        </div>
                                        {
                                            props.isMobile? (
                                                <React.Fragment>
                                                    <div  className={`${!props.isMobile ? style.creedRateDsc:style.creedRateDscM}`}>
                                             <span>
                                                <p>
                                                    I do not have religious beliefs
                                                </p>
                                                <p>and it does not matter to me</p>
                                            </span>
                                                    </div>
                                                    <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("0")
                                                            }}>0</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("1")
                                                            }}>1</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("2")
                                                            }}>2
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("3")
                                                            }}>3
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("4")
                                                            }}>4
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("5")
                                                            }}>5</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("6")
                                                            }}>6</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("7")
                                                            }}>7
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("8")
                                                            }}>8
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("9")
                                                            }}>9
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("10")
                                                            }}>10</button>
                                                        </div>
                                                    </div>
                                                    <div className={`mb-5 ${!props.isMobile ? style.creedRateDsc:style.creedRateDscM}`}>
                                            <span>
                                                <p>
                                                    Religious beliefs and values
                                                </p>
                                                <p>
                                                    are very important to me
                                                </p>
                                                </span>
                                                    </div>
                                                </React.Fragment>
                                            ):(
                                                <React.Fragment>
                                                    <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("0")
                                                            }}>0</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("1")
                                                            }}>1</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("2")
                                                            }}>2
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("3")
                                                            }}>3
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("4")
                                                            }}>4
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("5")
                                                            }}>5</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("6")
                                                            }}>6</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("7")
                                                            }}>7
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("8")
                                                            }}>8
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("9")
                                                            }}>9
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFirstQuestion(true);
                                                                setAnswer("10")
                                                            }}>10</button>
                                                        </div>
                                                    </div>
                                                    <div className={`mb-5 ${!props.isMobile ? style.creedRateDsc:style.creedRateDscM}`}>
                                                         <span>
                                                            <p>
                                                                I do not have religious beliefs
                                                            </p>
                                                            <p>and it does not matter to me</p>
                                                        </span>
                                                        <span>
                                                            <p>
                                                                Religious beliefs and values
                                                            </p>
                                                            <p>
                                                                are very important to me
                                                            </p>
                                                        </span>
                                                    </div>
                                                </React.Fragment>
                                            )
                                        }
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                Are national issues such as serving your compatriots, the future of the country, etc. important to you and may prevent you from migrating?
                                            </p>
                                        </div>
                                        {
                                            props.isMobile?(
                                                <React.Fragment>
                                                    <div className={`${!props.isMobile ? style.creedRateDsc:style.creedRateDscM}`}>
                                                        <span>I almost do not care</span>
                                                    </div>
                                                    <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("0")
                                                            }}>0</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("1")
                                                            }}>1</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("2")
                                                            }}>2
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("3")
                                                            }}>3
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("4")
                                                            }}>4
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("5")
                                                            }}>5</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("6")
                                                            }}>6</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("7")
                                                            }}>7
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("8")
                                                            }}>8
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("9")
                                                            }}>9
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("10")
                                                            }}>10</button>
                                                        </div>
                                                    </div>
                                                    <div className={`mb-5 ${!props.isMobile ? style.creedRateDsc:style.creedRateDscM}`}>
                                            <span>
                                                <p>
                                                    I almost do not care National
                                                </p>
                                                <p>
                                                    issues are very important to me
                                                </p>
                                            </span>
                                                    </div>
                                                </React.Fragment>
                                            ):(
                                                <React.Fragment>
                                                    <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("0")
                                                            }}>0</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("1")
                                                            }}>1</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("2")
                                                            }}>2
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("3")
                                                            }}>3
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("4")
                                                            }}>4
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("5")
                                                            }}>5</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("6")
                                                            }}>6</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("7")
                                                            }}>7
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("8")
                                                            }}>8
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("9")
                                                            }}>9
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setSecondQuestion(true);
                                                                setAnswer("10")
                                                            }}>10</button>
                                                        </div>
                                                    </div>
                                                    <div className={`mb-5 ${!props.isMobile ? style.creedRateDsc:style.creedRateDscM}`}>
                                                        <span>I almost do not care</span>

                                                        <span>
                                                <p>
                                                    I almost do not care National
                                                </p>
                                                <p>
                                                    issues are very important to me
                                                </p>
                                            </span>
                                                    </div>
                                                </React.Fragment>
                                            )
                                        }
                                    </React.Fragment>
                                ): !thirdQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                How important is the size of the immigrant community of the destination country and the existence of communities related to your country or nationality?
                                            </p>
                                        </div>
                                        {
                                            props.isMobile?(
                                                <React.Fragment>
                                                    <div className={`${style.creedRateDsc}`}>
                                                        <span>I would like to be away from my compatriots</span>
                                                    </div>
                                                    <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("0")
                                                            }}>0</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("1")
                                                            }}>1</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("2")
                                                            }}>2
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("3")
                                                            }}>3
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("4")
                                                            }}>4
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() =>{
                                                                setThirdQuestion(true);
                                                                setAnswer("5")
                                                            }}>5</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("6")
                                                            }}>6</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("7")
                                                            }}>7
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("8")
                                                            }}>8
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("9")
                                                            }}>9
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("10")
                                                            }}>10</button>
                                                        </div>
                                                    </div>
                                                    <div className={`mb-5 ${!props.isMobile ? style.creedRateDsc:style.creedRateDscM}`}>
                                            <span>
                                                <p>
                                                    I would like the country
                                                </p>
                                                <p>
                                                     I want to immigrate to to be fully immigrant
                                                </p>
                                            </span>
                                                    </div>
                                                </React.Fragment>
                                            ):(
                                                <React.Fragment>
                                                    <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("0")
                                                            }}>0</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("1")
                                                            }}>1</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("2")
                                                            }}>2
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("3")
                                                            }}>3
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("4")
                                                            }}>4
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() =>{
                                                                setThirdQuestion(true);
                                                                setAnswer("5")
                                                            }}>5</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("6")
                                                            }}>6</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("7")
                                                            }}>7
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("8")
                                                            }}>8
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("9")
                                                            }}>9
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setThirdQuestion(true);
                                                                setAnswer("10")
                                                            }}>10</button>
                                                        </div>
                                                    </div>
                                                    <div className={`mb-5 ${!props.isMobile ? style.creedRateDsc:style.creedRateDscM}`}>
                                                        <span>I would like to be away from my compatriots</span>
                                                        <span>
                                                <p>
                                                    I would like the country
                                                </p>
                                                <p>
                                                     I want to immigrate to to be fully immigrant
                                                </p>
                                            </span>
                                                    </div>
                                                </React.Fragment>
                                            )
                                        }

                                    </React.Fragment>
                                ) : !forthQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                How important is the similarity of the community context, social relations and other socio-cultural parameters of the destination country with your community?
                                            </p>
                                        </div>
                                        {
                                            props.isMobile?(
                                                <React.Fragment>
                                                    <div className={`${!props.isMobile ? style.creedRateDsc:style.creedRateDscM}`}>
                                            <span>
                                                <p>
                                                    I would like to experience a different society in
                                                </p>
                                                <p>
                                                      terms of social relations and cultural context
                                                </p>
                                              </span>
                                                    </div>
                                                    <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("0")
                                                            }}>0</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("1")
                                                            }}>1</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("2")
                                                            }}>2
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("3")
                                                            }}>3
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("4")
                                                            }}>4
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("5")
                                                            }}>5</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("6")
                                                            }}>6</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("7")
                                                            }}>7
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() =>{
                                                                setForthQuestion(true);
                                                                setAnswer("8")
                                                            }}>8
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("9")
                                                            }}>9
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("10")
                                                            }}>10</button>
                                                        </div>
                                                    </div>
                                                    <div className={`mb-5 ${!props.isMobile ? style.creedRateDsc:style.creedRateDscM}`}>
                                                        <span>I want it to be very similar</span>
                                                    </div>
                                                </React.Fragment>
                                            ):(
                                                <React.Fragment>
                                                    <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("0")
                                                            }}>0</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("1")
                                                            }}>1</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("2")
                                                            }}>2
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("3")
                                                            }}>3
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("4")
                                                            }}>4
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("5")
                                                            }}>5</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("6")
                                                            }}>6</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("7")
                                                            }}>7
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() =>{
                                                                setForthQuestion(true);
                                                                setAnswer("8")
                                                            }}>8
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("9")
                                                            }}>9
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => {
                                                                setForthQuestion(true);
                                                                setAnswer("10")
                                                            }}>10</button>
                                                        </div>
                                                    </div>
                                                    <div className={`mb-5 ${!props.isMobile ? style.creedRateDsc:style.creedRateDscM}`}>
                                                        <span>
                                                <p>
                                                    I would like to experience a different society in
                                                </p>
                                                <p>
                                                      terms of social relations and cultural context
                                                </p>
                                              </span>
                                                        <span>I want it to be very similar</span>
                                                    </div>
                                                </React.Fragment>
                                            )
                                        }
                                    </React.Fragment>
                                ): null
                            }
                        </div>
                    </div>
                    :
                    <HealthQuestion isMobile={props.isMobile} personalAnswers={props.personalAnswers} economyAnswer={props.economyAnswer} cultureAnswer={cultureAnswer}/>
            }

        </React.Fragment>
    )
}
export default CultureQuestions;