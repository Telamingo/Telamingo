import React, {useState} from "react";
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
    const [finalAnswer, setFinalAnswer] = useState([]);


    function checkFinalAnswer(event) {

        // setFinalAnswer((mentalProblem) => [...mentalProblem, event.target.value])
        setFinalAnswer(event.target.value)
    }
    console.log(setForthEnvironmentRate);
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
                                                                <button onClick={()=>setFirstEnvironmentRate(true)}>0
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setFirstEnvironmentRate(true)}>1
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setFirstEnvironmentRate(true)}>2
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setFirstEnvironmentRate(true)}>3
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setFirstEnvironmentRate(true)}>4
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setFirstEnvironmentRate(true)}>5
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
                                                                <button onClick={()=>setSecondEnvironmentRate(true)}>0
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setSecondEnvironmentRate(true)}>1
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setSecondEnvironmentRate(true)}>2
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setSecondEnvironmentRate(true)}>3
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setSecondEnvironmentRate(true)}>4
                                                                </button>
                                                            </div>
                                                            <div>
                                                                <button onClick={()=>setSecondEnvironmentRate(true)}>5
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
                                                               <button onClick={()=>setThirdEnvironmentRate(true)}>0
                                                               </button>
                                                           </div>
                                                           <div>
                                                               <button onClick={()=>setThirdEnvironmentRate(true)}>1
                                                               </button>
                                                           </div>
                                                           <div>
                                                               <button onClick={()=>setThirdEnvironmentRate(true)}>2
                                                               </button>
                                                           </div>
                                                           <div>
                                                               <button onClick={()=>setThirdEnvironmentRate(true)}>3
                                                               </button>
                                                           </div>
                                                           <div>
                                                               <button onClick={()=>setThirdEnvironmentRate(true)}>4
                                                               </button>
                                                           </div>
                                                           <div>
                                                               <button onClick={()=>setThirdEnvironmentRate(true)}>5
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
                                                              <button onClick={() => setFirstQuestion(true)}>0
                                                              </button>
                                                          </div>
                                                          <div>
                                                              <button onClick={() => setFirstQuestion(true)}>1
                                                              </button>
                                                          </div>
                                                          <div>
                                                              <button onClick={() => setFirstQuestion(true)}>2
                                                              </button>
                                                          </div>
                                                          <div>
                                                              <button onClick={() => setFirstQuestion(true)}>3
                                                              </button>
                                                          </div>
                                                          <div>
                                                              <button onClick={() => setFirstQuestion(true)}>4
                                                              </button>
                                                          </div>
                                                          <div>
                                                              <button onClick={() => setFirstQuestion(true)}>5
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
                                                            <button onClick={() => setSecondQuestion(true)}>0</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>1</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>2
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>3
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>4
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>5</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>6</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>7
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>8
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>9
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>10</button>
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
                                                            <button onClick={() => setSecondQuestion(true)}>0</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>1</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>2
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>3
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>4
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>5</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>6</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>7
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>8
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>9
                                                            </button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>10</button>
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
                                                <div
                                                    className={`${!props.isMobile ? style.finalAnswer : style.finalAnswerM}`}>
                                                    <label>
                                                        <input type="checkbox" value=" مسائل مالی و اقتصادی"
                                                               onChange={checkFinalAnswer}/>
                                                        Financial and economic issues
                                                    </label>
                                                    <label>
                                                        <input type="checkbox" value="مسائل شغلی و یا تحصیلی"
                                                               onChange={checkFinalAnswer}/>
                                                        Occupational or educational issues
                                                    </label>
                                                    <label>
                                                        <input type="checkbox" value=" مسائل مربوط به سلامت روحی و جسمی"
                                                               onChange={checkFinalAnswer}/>
                                                        Health issues (mental or physical)
                                                    </label>
                                                    <label>
                                                        <input type="checkbox"
                                                               value="مسائل مربوط به آب و هوا و شرایط اقلیمی"
                                                               onChange={checkFinalAnswer}/>
                                                        Socio-cultural differences
                                                    </label>
                                                    <label>
                                                        <input type="checkbox" value="تفاوت های فرهنگی-اجتماعی"
                                                               onChange={checkFinalAnswer}/>
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
                                                                onClick={() => setThirdQuestion(true)}>next
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
                                                                <input id="name" name="name" required/><br/>
                                                            </div>
                                                            <div className={`${!props.isMobile ? style.information:style.informationM} mt-3 mb-3`}>
                                                                <label htmlFor="email">Email: </label>
                                                                <input type="email" id="email" name="email" required/>
                                                            </div>
                                                            <div className={`${!props.isMobile ? style.information:style.informationM} mt-3 mb-3`}>
                                                                <label htmlFor="email">Phone number: </label>
                                                                <input type="tel" id="email" name="email" required/>
                                                            </div>
                                                        </div>
                                                        <div>
                                                            <input className={style.saveButton} type="submit"
                                                                   value="save" onClick={() => setForthQuestion(true)}/>
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