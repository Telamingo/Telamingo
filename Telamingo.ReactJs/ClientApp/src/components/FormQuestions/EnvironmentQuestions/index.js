import React, { useEffect, useState } from "react";
import style from "./environmentQuestions.module.css"

const EnvironmentQuestions = (props) => {

    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [thirdQuestion, setThirdQuestion] = useState(false);
    const [forthQuestion, setForthQuestion] = useState(false);
    const [firstEnvironmentRate, setFirstEnvironmentRate] = useState(false);
    const [secondEnvironmentRate, setSecondEnvironmentRate] = useState(false);
    const [thirdEnvironmentRate, setThirdEnvironmentRate] = useState(false);
    const [forthEnvironmentRate, setForthEnvironmentRate] = useState(false);
    const [firstChallenge, setFirstChallenge] = useState("");
    const [secondChallenge, setSecondChallenge] = useState("");
    const [thirdChallenge, setThirdChallenge] = useState("");
    const [forthChallenge, setForthChallenge] = useState("");
    const [fifthChallenge, setFifthChallenge] = useState("");
    const [challenges, setChallenges] = useState("");
    const [firstInformation, setFirstInformation] = useState("");
    const [secondInformation, setSecondInformation] = useState("");
    const [thirdInformation, setThirdInformation] = useState("");
    const [informations, setInformations] = useState("");
    const [finalAnswer, setFinalAnswer] = useState([]);
    const [environmentAnswer, setEnvironmentAnswer] = useState("");

    function checkFinalAnswer(event) {
        setFinalAnswer(event.target.value)
    }

    const checkFirstChallenge = (e) => {
        setFirstChallenge(e.target.value)
    }
    const checkSecondChallenge = (e) => {
        setSecondChallenge(e.target.value)
    }
    const checkThirdChallenge = (e) => {
        setThirdChallenge(e.target.value)
    }
    const checkForthChallenge = (e) => {
        setForthChallenge(e.target.value)
    }
    const combineChallenges = () => {
        setChallenges([...challenges, firstChallenge, secondChallenge, thirdChallenge, forthChallenge, fifthChallenge])
    }
    useEffect(() => {
        setAnswer(challenges)
    }, [challenges])

    const combineInformation = () => {
        setInformations([...informations, firstInformation, secondInformation, thirdInformation])
    }
    useEffect(() => {
        setAnswer(informations)
    }, [informations])

    const setAnswer = (answer) => {
        setEnvironmentAnswer([...environmentAnswer, answer])
    }

    if (environmentAnswer.length >= 8) {
        const UserAnswerDto = {
            "UserInformation": {
                "Name": environmentAnswer[7][0],
                "Email": environmentAnswer[7][1],
                "PhoneNumber": environmentAnswer[7][2]
            },
            "Cultural": {
                "ReligiousMatters": parseInt(props.cultureAnswer[0]),
                "NationalMatters": parseInt(props.cultureAnswer[1]),
                "ImmigrantCommunity": parseInt(props.cultureAnswer[2]),
                "Similarity": parseInt(props.cultureAnswer[3])
            },
            "Economy": {
                "CurrentJob": props.economyAnswer[0],
                "CurrentSaving": props.economyAnswer[3],
                "PreferredJob": props.economyAnswer[1],
                "PreferredSaving": props.economyAnswer[2]
            },
            "Environmental": {
                "Cloudy": parseInt(environmentAnswer[1]),
                "Snowy": parseInt(environmentAnswer[2]),
                "Sunny": parseInt(environmentAnswer[3]),
                "Moderate": parseInt(environmentAnswer[4]),
                "UnusualDaytime": parseInt(environmentAnswer[5])
            },
            "Mental": {
                "MentalIll": props.mentalHealthAnswer[1],
                "First": "",
                "Secend": "",
                "Third": "",
                "FamilyVisit": props.mentalHealthAnswer[props.mentalHealthAnswer.length - 1]
            },
            "MostImportants": {
                "Problems": environmentAnswer[6]
            },
            "Physical": {
                "MedicineNeed": props.healthAnswer[1],
                "SpecialIll": props.healthAnswer[2],
                "First": "",
                "Secend": "",
                "Third": "",
                "MedicineCost": props.healthAnswer[props.healthAnswer.length-4],
                "TraditionalFood": parseInt(props.healthAnswer[props.healthAnswer.length-3]),
                "FastFood": parseInt(props.healthAnswer[props.healthAnswer.length-2]),
                "Vegeterian": parseInt(props.healthAnswer[props.healthAnswer.length-1])
            },
            "Primary": {
                "User_Destination": "canada",
                "Preferred_Visa_Type": "job",
                "Age": props.personalAnswers[1],
                "Sex": props.personalAnswers[2],
                "First_Lang": props.personalAnswers[4][0],
                "Level": props.personalAnswers[4][1],
                "Second_Lang": props.personalAnswers[5][0],
                "Second_LangLevel":props.personalAnswers[5][1],
                "Third_Lang": props.personalAnswers[6][0],
                "Third_LangLevel": props.personalAnswers[6][1],
                "MaritalStatus": props.personalAnswers[3],
                "NumberOfCompanions": parseInt(props.personalAnswers[props.personalAnswers.length - 1])
            }
        }
        console.log(UserAnswerDto)


        fetch('https://localhost:5001/api/Form/UserAnwer', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                UserAnswerDto
            }),
        })
            .then(response => response.json())
            .then(UserAnswerDto => {
                console.log('Success:', UserAnswerDto);
            })
            .catch((error) => {
                console.error('Error:', error);
            });

    }

    console.log(environmentAnswer)


    return (
        <React.Fragment>
            {
                !secondQuestion ?
                    <div className={` col-lg-12 ${style.questionBody}`}>
                        <div className={`${style.questionContent} mt-5`} dir='ltr'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p>
                                                How compatible are you with any of the following weather conditions?
                                            </p>
                                        </div>
                                        {
                                            !firstEnvironmentRate ? (
                                                <div className={`mt-3 mb-5 ${!props.isMobile ? style.environmentHoby:style.environmentHobyM}`}>
                                                    <div>
                                                        <label>Mostly cloudy and rainy:</label>
                                                        <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setFirstEnvironmentRate(true);
                                                                    setAnswer("0")
                                                                }}>0
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setFirstEnvironmentRate(true);
                                                                    setAnswer("1")
                                                                }}>1
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setFirstEnvironmentRate(true);
                                                                    setAnswer("2")
                                                                }}>2
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setFirstEnvironmentRate(true);
                                                                    setAnswer("3")
                                                                }}>3
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setFirstEnvironmentRate(true);
                                                                    setAnswer("4")
                                                                }}>4
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setFirstEnvironmentRate(true);
                                                                    setAnswer("5")
                                                                }}>5
                                                                </button>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            ) : !secondEnvironmentRate ? (
                                                <div className={`mt-3 mb-5 ${!props.isMobile ? style.environmentHoby:style.environmentHobyM}`}>
                                                    <div>
                                                        <label>Mostly snowy: </label>
                                                        <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setSecondEnvironmentRate(true);
                                                                    setAnswer("0")
                                                                }}>0
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setSecondEnvironmentRate(true);
                                                                    setAnswer("1")
                                                                }}>1
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setSecondEnvironmentRate(true);
                                                                    setAnswer("2")
                                                                }}>2
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setSecondEnvironmentRate(true);
                                                                    setAnswer("3")
                                                                }}>3
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setSecondEnvironmentRate(true);
                                                                    setAnswer("4")
                                                                }}>4
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=> {
                                                                    setSecondEnvironmentRate(true);
                                                                    setAnswer("5")
                                                                }}>5
                                                                </button>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div className={`${style.buttons}`}>
                                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                    onClick={() => setFirstEnvironmentRate(false)}>previous
                                                            </button>
                                                        </div>
                                                    </div>
                                                </div>
                                            ) : !thirdEnvironmentRate ? (
                                                <div className={`mt-3 mb-5 ${!props.isMobile ? style.environmentHoby:style.environmentHobyM}`}>
                                                   <div>
                                                       <label>Mostly Sunny:</label>
                                                       <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                           <div>
                                                               <button onClick={()=> {
                                                                   setThirdEnvironmentRate(true);
                                                                   setAnswer("0")
                                                               }}>0
                                                               </button>
                                                           </div>
                                                           <div>
                                                               <button onClick={()=> {
                                                                   setThirdEnvironmentRate(true);
                                                                   setAnswer("1")
                                                               }}>1
                                                               </button>
                                                           </div>
                                                           <div>
                                                               <button onClick={()=> {
                                                                   setThirdEnvironmentRate(true);
                                                                   setAnswer("2")
                                                               }}>2
                                                               </button>
                                                           </div>
                                                           <div>
                                                               <button onClick={()=> {
                                                                   setThirdEnvironmentRate(true);
                                                                   setAnswer("3")
                                                               }}>3
                                                               </button>
                                                           </div>
                                                           <div>
                                                               <button onClick={()=> {
                                                                   setThirdEnvironmentRate(true);
                                                                   setAnswer("4")
                                                               }}>4
                                                               </button>
                                                           </div>
                                                           <div>
                                                               <button onClick={()=> {
                                                                   setThirdEnvironmentRate(true);
                                                                   setAnswer("5")
                                                               }}>5
                                                               </button>
                                                           </div>
                                                       </div>
                                                   </div>
                                                    <div className={`${style.buttons}`}>
                                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                    onClick={() => setSecondEnvironmentRate(false)}>previous
                                                            </button>
                                                        </div>
                                                    </div>
                                                </div>
                                            ) : !forthEnvironmentRate && (
                                                <div className={`mt-3 mb-5 ${!props.isMobile ? style.environmentHoby:style.environmentHobyM}`}>
                                                  <div>
                                                      <label>Four seasons and moderate:</label>
                                                      <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM}`}>
                                                          <div>
                                                              <button onClick={() => {
                                                                  setFirstQuestion(true);
                                                                  setAnswer("0")
                                                              }}>0
                                                              </button>
                                                          </div>
                                                          <div>
                                                              <button onClick={() => {
                                                                  setFirstQuestion(true);
                                                                  setAnswer("1")
                                                              }}>1
                                                              </button>
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
                                                              }}>5
                                                              </button>
                                                          </div>
                                                      </div>
                                                  </div>
                                                    <div className={`${style.buttons}`}>
                                                        <div className={`${!props.isMobile ? style.previousButton : style.previousButtonM}`}>
                                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                    onClick={() => setThirdEnvironmentRate(false)}>previous
                                                            </button>
                                                        </div>
                                                    </div>
                                                </div>
                                            )
                                        }
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                Problems with unusual day and night hours (long day or long night)?
                                            </p>
                                        </div>
                                        {
                                            props.isMobile?(
                                                <React.Fragment>
                                                    <div className={`${!props.isMobile?style.creedRateDsc:style.creedRateDscM}`}>
                                                        <span>It is not tolerable for me at all</span>
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
                                                    <div className={`mb-5 ${!props.isMobile?style.creedRateDsc:style.creedRateDscM}`}>
                                                        <span>It does not matter to me</span>
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
                                                    <div className={`mb-5 ${!props.isMobile?style.creedRateDsc:style.creedRateDscM}`}>
                                                        <span>It is not tolerable for me at all</span>
                                                        <span>It does not matter to me</span>
                                                    </div>
                                                </React.Fragment>
                                            )
                                        }
                                    </React.Fragment>
                                ) : null
                            }
                        </div>
                    </div>
                    :
                    <>
                        {
                            !thirdQuestion ? (
                                <React.Fragment>
                                    <div className={` col-lg-12 ${style.questionBody}`}>
                                        <div className={`${style.questionContent} mt-5`} dir='ltr'>
                                            <React.Fragment>
                                                <div className={`mb-3 ${style.question}`}>
                                                    <p>
                                                        In general, what are the two most important challenges of
                                                        immigration in your opinion?
                                                    </p>
                                                    <p className={`${style.questionDsc}`}>
                                                        (Choose two options)
                                                    </p>
                                                </div>
                                                <div className={`${!props.isMobile ? style.finalAnswer : style.finalAnswerM}`}>
                                                    <label>
                                                        <input type="checkbox" value="Financial and economic issues"
                                                               onClick={(e)=> {
                                                                   checkFinalAnswer(e);
                                                                   setFifthChallenge(e.target.value)
                                                               }}/>
                                                        Financial and economic issues
                                                    </label>
                                                    <label>
                                                        <input type="checkbox" value=" Occupational or educational issues"
                                                               onClick={(e)=>{checkFinalAnswer(e);checkFirstChallenge(e)}}/>
                                                        Occupational or educational issues
                                                    </label>
                                                    <label>
                                                        <input type="checkbox" value="Health issues (mental or physical)"
                                                               onClick={(e)=>{checkFinalAnswer(e);checkSecondChallenge(e)}}/>
                                                        Health issues (mental or physical)
                                                    </label>
                                                    <label>
                                                        <input type="checkbox" value="Socio-cultural differences"
                                                               onClick={(e)=>{checkFinalAnswer(e);checkThirdChallenge(e)}}/>
                                                        Socio-cultural differences
                                                    </label>
                                                    <label>
                                                        <input type="checkbox" value="Weather and climate issues"
                                                               onClick={(e)=>{checkFinalAnswer(e);checkForthChallenge(e)}}/>
                                                        Weather and climate issues
                                                    </label>
                                                </div>
                                                {
                                                    finalAnswer === "" ? (
                                                        <div
                                                            className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                            <button
                                                                className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>next
                                                            </button>
                                                        </div>
                                                    ) : (
                                                        <div
                                                            className={`${!props.isMobile ? style.nextButton : style.nextButtonM}`}>
                                                            <button
                                                                className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                onClick={() => {
                                                                    setThirdQuestion(true);
                                                                    combineChallenges();
                                                                }}>next
                                                            </button>
                                                        </div>
                                                    )
                                                }
                                            </React.Fragment>
                                        </div>
                                    </div>
                                </React.Fragment>
                            ) : (
                                <React.Fragment>
                                    {
                                        !forthQuestion ? (
                                            <React.Fragment>
                                                <div className={`mt-5 col-lg-12 ${style.questionBody}`}>
                                                    <div className={`mb-3 mt-5 ${style.question}`}>
                                                        <h3>
                                                            please enter your
                                                            specification below:
                                                        </h3>
                                                        <div style={{display:"flex"}} className="mb-5 mt-5">
                                                            <div className={`${!props.isMobile ? style.information:style.informationM} mt-3 mb-3`}>
                                                                <label htmlFor="name">Name: </label>
                                                                <input id="name" name="name" required onChange={(e)=>setFirstInformation(e.target.value)}/><br/>
                                                            </div>
                                                            <div className={`${!props.isMobile ? style.information:style.informationM} mt-3 mb-3`}>
                                                                <label htmlFor="email">Email: </label>
                                                                <input type="email" id="email" name="email" required onChange={(e)=>setSecondInformation(e.target.value)}/>
                                                            </div>
                                                            <div className={`${!props.isMobile ? style.information:style.informationM} mt-3 mb-3`}>
                                                                <label htmlFor="email">Phone number: </label>
                                                                <input type="tel" id="email" name="email" required onChange={(e)=>setThirdInformation(e.target.value)}/>
                                                            </div>
                                                        </div>
                                                        <div>
                                                            <input className={style.saveButton} type="submit"
                                                                   value="save" onClick={() => {
                                                                setForthQuestion(true);
                                                                combineInformation();
                                                            }}/>
                                                        </div>
                                                    </div>
                                                </div>
                                            </React.Fragment>
                                        ) : (
                                            <React.Fragment>
                                                <div className={`mt-5 col-lg-12 ${style.questionBody}`}>
                                                    <div className={`mb-3 ${style.question}`}>
                                                        <h3 className="mb-5 mt-5" style={{color:"green"}}>
                                                            thank you so much, we will email the response for you.
                                                        </h3>
                                                    </div>
                                                </div>
                                            </React.Fragment>
                                        )
                                    }
                                </React.Fragment>
                            )
                        }
                    </>
            }
        </React.Fragment>
    )
}
export default EnvironmentQuestions;