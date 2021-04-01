import '../styles/globals.scss'
import React from 'react'
import type { AppProps } from 'next/app'

const SafeHydrate: React.FC = ({ children }) => {
  return (
    <div suppressHydrationWarning={true}>
      {typeof window === 'undefined' ? null : children}
    </div>
  )
}

const MyApp: React.FC<AppProps> = ({ Component, pageProps }) => {
  return (
    <SafeHydrate>
      <Component {...pageProps} />
    </SafeHydrate>
  )
}

export default MyApp
