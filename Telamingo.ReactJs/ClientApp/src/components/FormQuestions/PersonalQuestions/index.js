import React, {useState,useEffect} from "react";
import style from "./personalQuestion.module.css";
import EconomyQuestions from "../EconomyQuestions";

const PersonalQuestions = (props) => {
    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [thirdQuestion, setThirdQuestion] = useState(false);
    const [forthQuestion, setForthQuestion] = useState(false);
    const [fifthQuestion, setFifthQuestion] = useState(false);
    const [sixthQuestion, setSixthQuestion] = useState(false);
    const [haveFollower, setHaveFollower] = useState(false);
    const [firstLang, setFirstLang] = useState(false);
    const [secondLang, setSecondLang] = useState(false);
    const [thirdLang, setThirdLang] = useState(false);
    const [firstLanLevel, setFirstLanLevel] = useState("");
    const [firstLanContent, setFirstLanContent] = useState("");
    const [secondLanLevel, setSecondLanLevel] = useState("");
    const [secondLanContent, setSecondLanContent] = useState("");
    const [thirdLanLevel, setThirdLanLevel] = useState("");
    const [thirdLanContent, setThirdLanContent] = useState("");
    const [personalAnswers, setPersonalAnswers] = useState("");
    const [firstLanData, setFirstLanData] = useState("");
    const [secondLanData, setSecondLanData] = useState("");
    const [thirdLanData, setThirdLanData] = useState("");

    const language = [
        {
            value: "English",
            label: "English",
            id:1
        },
        {
            value: "French",
            label: "French",
            id:2
        },
        {
            value: "Italian",
            label: "Italian",
            id:3
        },
    ]

    const combineFirstLanData=()=>{
        setFirstLanData([...firstLanData,firstLanContent,firstLanLevel])
    }
    useEffect(()=>{
        setAnswer(firstLanData)
    },[firstLanData])
    const combineSecondLanData=()=>{
        setSecondLanData([...secondLanData,secondLanContent,secondLanLevel])
    }
    useEffect(()=>{
        setAnswer(secondLanData)
    },[secondLanData])
    const combineThirdLanData=()=>{
        setThirdLanData([...thirdLanData,thirdLanContent,thirdLanLevel])
    }
    useEffect(()=>{
        setAnswer(thirdLanData)
    },[thirdLanData])

    useEffect(()=>{
        setAnswer(props.destination)
    },[])

    const setAnswer=(answer)=>{
        setPersonalAnswers([...personalAnswers,answer])
    }
    console.log(personalAnswers)

    return (
        <React.Fragment>
            {
                !sixthQuestion ? (
                    <div className={` col-lg-12 container ${style.questionBody}`}>
                        <div className={`${style.questionContent} mt-5`} dir='ltr'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                How old are you?
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.chooseAge : style.chooseAgeM} mt-5 mb-5`}>
                                            <div>
                                                <button onClick={() => {setFirstQuestion(true);setAnswer("Over 50 years")}}>Over 50 years</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setFirstQuestion(true);
                                                    setAnswer("Between 35 and 49 years")
                                                }}>Between 35 and 49 years
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setFirstQuestion(true);
                                                    setAnswer("Between 25 and 34 years")
                                                }} >Between 25 and 34 years
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setFirstQuestion(true);
                                                    setAnswer(" Between 18 and 24 years")
                                                }} > Between 18 and 24 years
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setFirstQuestion(true);
                                                    setAnswer("Under 18 years")
                                                }}>Under 18 years</button>
                                            </div>
                                        </div>
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3  ${style.question}`}>
                                            <p className={`mt-3`}>
                                                What is your Sex?
                                            </p>
                                        </div>
                                        <div className={`${!props.isMobile ? style.chooseAge : style.chooseAgeM} mt-5 mb-5`}>
                                            <div>
                                                <button onClick={() => {
                                                    setSecondQuestion(true);
                                                    setAnswer("Man")
                                                }} >Man</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setSecondQuestion(true);
                                                    setAnswer("Woman")
                                                }}  >Woman</button>
                                            </div>
                                            <div>
                                                <button  onClick={() => {
                                                    setSecondQuestion(true);
                                                    setAnswer("Other")
                                                }} >Other</button>
                                            </div>
                                        </div>
                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setFirstQuestion(false)}>previous
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : !thirdQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                Marital Status:
                                            </p>
                                        </div>
                                        <div className={`${!props.isMobile ? style.chooseAge : style.chooseAgeM} mt-5 mb-5`}>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("single")
                                                }} >Single</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Married")
                                                }} >Married</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Seperated")
                                                }} >Seperated</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Divorced")
                                                }} >Divorced</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Widow")
                                                }} >Widow</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setThirdQuestion(true);
                                                    setAnswer("Other")
                                                }}>Other</button>
                                            </div>
                                        </div>
                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setSecondQuestion(false)}>previous
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : !forthQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                Language Status:
                                            </p>
                                        </div>
                                        <div className={`${!props.isMobile ? style.language : style.languageM}`}>
                                            {
                                                !firstLang ? (
                                                       <React.Fragment>
                                                           <div className="mb-3">
                                                               <label onChange={(e)=>setFirstLanContent(e.target.value)}>
                                                                   Choose First Language:
                                                                   <select>
                                                                       <option selected disabled="">Choose Your First Language</option>
                                                                       {
                                                                           language.map((lang)=>(
                                                                               <option value={lang.value} key={lang.id}>{lang.label}</option>
                                                                           ))
                                                                       }
                                                                   </select>
                                                               </label>
                                                               <label onChange={(e)=> setFirstLanLevel(e.target.value)}>
                                                                   First Language Level:
                                                                   <select>
                                                                       <option selected disabled="">Choose Your Level</option>
                                                                       <option>Advance</option>
                                                                       <option>Intermediate</option>
                                                                       <option>Beginner</option>
                                                                   </select>
                                                               </label>
                                                           </div>
                                                           <div className={`${style.buttons}`}>
                                                               <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                                   <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                           onClick={() => setThirdQuestion(false)}>previous
                                                                   </button>
                                                               </div>
                                                               {
                                                                   firstLanLevel === "" ?
                                                                       <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                                           <button
                                                                               className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>next
                                                                           </button>
                                                                       </div>
                                                                       :
                                                                       <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                                           <button
                                                                               className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                               onClick={() => {
                                                                                   setFirstLang(true);
                                                                                   combineFirstLanData()
                                                                               }}>next
                                                                           </button>
                                                                       </div>
                                                               }
                                                           </div>
                                                       </React.Fragment>
                                                ) : !secondLang ? (
                                                    <React.Fragment>
                                                        <div  className="mb-3">
                                                            <label onChange={(e)=>setSecondLanContent(e.target.value)}>
                                                                Choose Second Language:
                                                                <select>
                                                                    <option value="Choose Your Second Language" selected disabled="">Choose Your Second Language</option>
                                                                    <option value="english">English</option>
                                                                    <option value="French">French</option>
                                                                    <option value="Italian">Italian</option>
                                                                </select>
                                                            </label>
                                                            <label onChange={(e)=> setSecondLanLevel(e.target.value)}>
                                                                Second Language Level:
                                                                <select>
                                                                    <option value="advance">Advance</option>
                                                                    <option value="intermediate">Intermediate</option>
                                                                    <option value="beginner">Beginner</option>
                                                                    <option value="Choose Your Level" selected disabled="">Choose Your Level</option>
                                                                </select>
                                                            </label>
                                                        </div>
                                                        <div className={`${style.buttons}`}>
                                                            <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                                <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                        onClick={() => setFirstLang(false)}>previous
                                                                </button>
                                                            </div>
                                                            <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                                <button
                                                                    className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                    onClick={() => {
                                                                        setSecondLang(true);
                                                                        combineSecondLanData()
                                                                    }}>next
                                                                </button>
                                                            </div>
                                                        </div>
                                                    </React.Fragment>
                                                ) : !thirdLang ? (
                                                    <React.Fragment>
                                                        <div  className="mb-3">
                                                            <label onChange={(e)=>setThirdLanContent(e.target.value)}>
                                                                Choose Third Language:
                                                                <select>
                                                                    <option defaultValue="Choose Your Third Language" disabled="" selected>Choose Your Third Language</option>
                                                                    <option value="english">English</option>
                                                                    <option value="French">French</option>
                                                                    <option value="Italian">Italian</option>
                                                                </select>
                                                            </label>
                                                            <label onChange={(e)=> setThirdLanLevel(e.target.value)}>
                                                                Third Language Level:
                                                                <select>
                                                                    <option value="Advance">Advance</option>
                                                                    <option value="Intermediate">Intermediate</option>
                                                                    <option value="beginner">beginner</option>
                                                                    <option value="Choose Your Level" selected disabled="">Choose Your Level</option>
                                                                </select>
                                                            </label>
                                                        </div>
                                                        <div className={`${style.buttons}`}>
                                                            <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                                <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                        onClick={() => setSecondLang(false)}>previous
                                                                </button>
                                                            </div>
                                                            <div className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                                <button
                                                                    className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                    onClick={() => {
                                                                        setForthQuestion(true);
                                                                        combineThirdLanData()
                                                                    }}>next
                                                                </button>
                                                            </div>
                                                        </div>
                                                    </React.Fragment>
                                                ) : null
                                            }
                                        </div>
                                    </React.Fragment>
                                ) : !fifthQuestion ? (
                                    <React.Fragment>
                                        {
                                            !haveFollower ? (
                                                <React.Fragment>
                                                    <div className={`mb-3 ${style.question}`}>
                                                        <p className={`mt-3`}>
                                                            Are you planning to immigrate alone?
                                                        </p>
                                                    </div>
                                                    <div className={` ${!props.isMobile ? style.chooseCount : style.chooseCountM} mt-5 mb-5`}>
                                                        <div>
                                                            <button onClick={() => {
                                                                setFifthQuestion(true)
                                                                setAnswer("0")
                                                            }}>Yes</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setHaveFollower(true)}>No</button>
                                                        </div>
                                                    </div>
                                                    <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                        <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                onClick={() => setForthQuestion(false)}>previous
                                                        </button>
                                                    </div>
                                                </React.Fragment>
                                            ) : (
                                                <React.Fragment>
                                                            <React.Fragment>
                                                                <div className={`mb-3 ${style.question}`}>
                                                                    <p className={`mt-3`}>
                                                                        How many person are be with you?
                                                                    </p>
                                                                </div>
                                                                <div className={`${!props.isMobile ? style.chooseCount : style.chooseCountM} mt-5 mb-5`}>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => {
                                                                                setFifthQuestion(true);
                                                                                setAnswer("1")
                                                                            }}>1
                                                                        </button>
                                                                    </div>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => {
                                                                                setFifthQuestion(true);
                                                                                setAnswer("2")
                                                                            }}>2
                                                                        </button>
                                                                    </div>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => {
                                                                                setFifthQuestion(true);
                                                                                setAnswer("3")
                                                                            }}>3
                                                                        </button>
                                                                    </div>
                                                                    <div>
                                                                        <button
                                                                            onClick={() => {
                                                                                setFifthQuestion(true);
                                                                                setAnswer("4")
                                                                            }}>4
                                                                        </button>
                                                                    </div>
                                                                </div>
                                                            </React.Fragment>
                                                </React.Fragment>
                                            )
                                        }
                                    </React.Fragment>
                                ) : !sixthQuestion &&
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                How do you want to get a visa faster?
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.chooseAge : style.chooseAgeM} mt-5 mb-5`}>
                                            <div>
                                                <button onClick={() => {setSixthQuestion(true);setAnswer("educational")}}>educational</button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setSixthQuestion(true);
                                                    setAnswer("Job Offer (or Seeker)")
                                                }}>Job Offer (or Seeker)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setSixthQuestion(true);
                                                    setAnswer("Start-Up Visa")
                                                }} >Start-Up Visa
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setSixthQuestion(true);
                                                    setAnswer("investment")
                                                }} >investment
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => {
                                                    setSixthQuestion(true);
                                                    setAnswer("I do not know")
                                                }}>I do not know</button>
                                            </div>
                                        </div>
                                    </React.Fragment>
                            }
                        </div>
                    </div>
                ) : (
                    <EconomyQuestions isMobile={props.isMobile} personalAnswers={personalAnswers}/>
                )
            }
        </React.Fragment>
    )
}
export default PersonalQuestions;